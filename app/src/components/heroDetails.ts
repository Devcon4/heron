import { css, html, LitElement } from 'lit';
import { customElement, state } from 'lit/decorators.js';
import { combineLatest } from 'rxjs';
import { map } from 'rxjs/operators';
import { groupBy, Lookup } from '../services/arrayUtils';
import { HeroPortraits } from '../services/assetLookups';
import { async } from '../services/decoratorUtils';
import heroState, { Hero, HeroAbility } from '../services/heroState';
import releaseState, { HeroUpdate } from '../services/releaseState';
import {
  flexHostStyles,
  globalStyles,
  MinWidthStyles,
  ShadowStyles,
} from '../styles/globalStyles';
import { loading } from './loading';

const heroAbilities = combineLatest([
  heroState.heroDetails,
  heroState.heroAbilities,
]).pipe(
  map(([hero, abilities]) => abilities.filter((a) => a.heroid !== hero?.id))
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
import { Tab } from '@material/mwc-tab';
export class NavTabElement extends Tab {}

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

  detailsBody() {
    return html` <div class="card el-small">
        <img
          class="portrait"
          src="${HeroPortraits[this.heroDetails.id]}"
          alt="${this.heroDetails.name}"
        />
        <div class="header">
          <h2>${this.heroDetails.name}</h2>
          <div class="type">${this.heroDetails.type}</div>
        </div>
        <p class="description">${this.heroDetails.description}</p>
      </div>
      ${this.tabs()} ${this.abilities()}
      <div class="changelog"></div>`;
  }

  tabs() {
    return html`<mwc-tab-bar activeIndex="1">
      <mwc-tab label="Current"></mwc-tab>
      <mwc-tab label="History"></mwc-tab>
    </mwc-tab-bar>`;
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

        .portrait {
          display: flex;
        }

        .portrait {
          float: left;
          border-radius: 10px;
          filter: drop-shadow(0px 2px 4px rgba(0, 0, 0, 0.4));
          background-color: var(--hero-background);
          margin: 8px;
          margin-right: 21px;
        }

        .type {
          font-size: 1.4rem;
          justify-self: flex-end;
        }

        .header {
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
