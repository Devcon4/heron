import { css, html, LitElement } from 'lit';
import { customElement, state } from 'lit/decorators.js';
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

@customElement('hero-details')
export default class HeroDetailsElement extends LitElement {
  @state()
  @async(heroState.heroDetails)
  heroDetails: Hero;

  @state()
  @async(heroState.heroAbilities)
  heroAbilities: HeroAbility[];

  @state()
  @async(releaseState.heroUpdates)
  heroUpdates: HeroUpdate[];

  @state()
  @async(releaseState.releaseDetails)
  releaseDetails: Release;

  detailsBody() {
    return html`<h2 class="el-small">
        <div class="name">${this.heroDetails.name}</div>
        <div class="release">${this.releaseDetails?.title}</div>
      </h2>
      ${this.abilities()}
      <div class="changelog">
        <h3>Changelog</h3>
        ${this.changelog()}
      </div>`;
  }

  abilities() {
    return this.heroAbilities.map(
      (a) =>
        html`<div class="ability">
          <h3 class="title">${a.name}</h3>
          <p>${a.description}</p>
        </div>`
    );
  }

  changelog() {
    return this.heroUpdates.map(
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
        h2 {
          display: flex;
          justify-content: space-between;
          margin-top: 42px;
          background-color: var(--hero-surface);
          padding: 12px;
        }

        .release {
          font-size: 1rem;
          text-transform: Capitalize;
        }
      `,
    ];
  }
}
