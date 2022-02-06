import { css, html, LitElement } from 'lit';
import { customElement, state } from 'lit/decorators.js';
import { async } from '../services/decoratorUtils';
import heroState, { HashTable, Hero } from '../services/heroState';
import {
  flexHostStyles,
  globalStyles,
  MinWidthStyles,
  ShadowStyles,
} from '../styles/globalStyles';
import { loading } from './loading';

@customElement('hero-gallery')
export default class GalleryElement extends LitElement {
  @state()
  @async(heroState.heroes)
  heroes: Hero[];

  @state()
  @async(heroState.heroHashLookup)
  heroHash: HashTable;

  heroList() {
    return html`${this.heroes.map(
      (h) =>
        html`<div class="hero card">
          <a href="/herodetails/${this.heroHash.inverse[h.id]}">${h.name}</a>
        </div>`
    )}`;
  }

  render() {
    return html`<div class="gallery flex">
      <h2 class="el-small">Gallery</h2>
      ${this.heroes.length ? this.heroList() : loading()}
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
          background-color: var(--hero-surface);
          padding: 12px;
        }
      `,
    ];
  }
}
