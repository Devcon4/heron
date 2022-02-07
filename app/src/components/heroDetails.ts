import { css, html, LitElement } from 'lit';
import { customElement, state } from 'lit/decorators.js';
import { async } from '../services/decoratorUtils';
import heroState, { Hero, HeroAbility } from '../services/heroState';
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

  detailsBody() {
    return html`<h2 class="el-small">${this.heroDetails.name}</h2>
      ${this.abilities()}`;
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
          margin-top: 42px;
          background-color: var(--hero-surface);
          padding: 12px;
        }
      `,
    ];
  }
}
