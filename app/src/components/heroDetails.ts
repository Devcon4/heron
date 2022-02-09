import { css, html, LitElement } from 'lit';
import { customElement, state } from 'lit/decorators.js';
import { DateTime } from 'luxon';
import { combineLatest } from 'rxjs';
import { map } from 'rxjs/operators';
import { groupBy, Lookup, order } from '../services/arrayUtils';
import { async } from '../services/decoratorUtils';
import heroState, { Hero, HeroAbility } from '../services/heroState';
import releaseState, { HeroUpdate, Release } from '../services/releaseState';
import {
  flexHostStyles,
  globalStyles,
  MinWidthStyles,
  ShadowStyles,
} from '../styles/globalStyles';
import { loading } from './loading';

const releases = releaseState.releases.pipe(
  map((l) =>
    l
      .map((r) => ({ ...r, releaseDate: DateTime.fromISO(r.releaseDate) }))
      .sort(order((r) => r.releaseDate))
  )
);

const heroAbilities = combineLatest([
  heroState.heroDetails,
  heroState.heroAbilities,
]).pipe(
  map(([hero, abilities]) => abilities.filter((a) => a.heroid !== hero.id))
);

const heroUpdateLookup = combineLatest([
  heroAbilities,
  releaseState.heroUpdates,
]).pipe(
  map(([abilities, updates]) =>
    updates.filter((u) => abilities.some((a) => u.heroAbilityId === a.id))
  ),
  map((updates) => groupBy(updates, (u) => u.heroAbilityId))
);

@customElement('hero-details')
export default class HeroDetailsElement extends LitElement {
  @state()
  @async(heroState.heroDetails)
  heroDetails: Hero;

  @state()
  @async(heroAbilities)
  heroAbilities: HeroAbility[];

  @state()
  @async(heroUpdateLookup)
  heroUpdateLookup: Lookup<HeroUpdate[]>;

  @state()
  @async(releases)
  releases: Release[];

  @state()
  @async(releaseState.releaseDetails)
  releaseDetails: Release;

  updateRelease(index: number) {
    const id = this.releases[index].id;
    releaseState.getRelease(id);
  }

  releaseSelect() {
    return html`<mwc-select
      @selected="${({ detail }) => this.updateRelease(detail.index)}"
      value="${this.releases[0].id}"
      label="Release"
    >
      ${this.releases.map(
        (r) =>
          html`<mwc-list-item value="${r.id}"
            >${DateTime.fromISO(r.releaseDate, {
              zone: 'UTC',
            }).toLocaleString(DateTime.DATE_MED)}</mwc-list-item
          >`
      )}
    </mwc-select>`;
  }

  detailsBody() {
    return html` <div class="card">
        <h2 class="el-small">
          <div class="name">${this.heroDetails.name}</div>
          <div class="release">
            ${this.releases?.length ? this.releaseSelect() : undefined}
          </div>
        </h2>
      </div>
      ${this.abilities()}
      <div class="changelog"></div>`;
  }

  abilities() {
    return (this.heroAbilities || []).map(
      (a) =>
        html`<div class="ability">
          <h3 class="title">${a.name}</h3>
          <p>${a.description}</p>
          <h4>Changelog</h4>
          ${this.heroUpdateLookup ? this.changelog(a.id) : undefined}
        </div>`
    );
  }

  changelog(id: string) {
    return (this.heroUpdateLookup[id] || []).map(
      (u) => html`<div class="update">${u.changeNotes}</div>`
    );
  }

  render() {
    return html`<div class="gallery flex">
      ${this.heroDetails ? this.detailsBody() : loading()}
    </div>`;
  }

  static get styles() {
    return [
      globalStyles,
      flexHostStyles,
      MinWidthStyles,
      ShadowStyles,
      css`
        .card {
          margin-top: 42px;
          background-color: var(--hero-surface);
          padding: 12px;
        }

        h2 {
          display: flex;
          justify-content: space-between;
        }

        .release {
          font-size: 1rem;
          text-transform: Capitalize;
        }
      `,
    ];
  }
}
