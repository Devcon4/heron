import { css, html, LitElement } from 'lit';
import { customElement, state } from 'lit/decorators.js';
import { HashTable } from '../services/arrayUtils';
import { HeroIcons } from '../services/assetLookups';
import { async } from '../services/decoratorUtils';
import heroState, { Hero } from '../services/heroState';
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
    return html`<div class="hero-list">
      ${this.heroes.map(
        (h) =>
          html`<div class="hero card el-small">
            <a href="/herodetails/${this.heroHash.inverse[h.id]}">
              <img class="portrait" src="${HeroIcons[h.id]}" alt="${h.name}" />
              <div class="title">${h.name}</div>
            </a>
          </div>`
      )}
    </div>`;
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

        .hero-list {
          display: flex;
          flex-wrap: wrap;
        }

        .card {
          background-color: var(--hero-surface);
          margin: 12px;
          border-radius: 5px;
          outline: 1px solid transparent;
          filter: brightness(100%);
          transition: all linear 250ms;
          overflow: hidden;
        }

        .card:hover {
          outline: 1px solid var(--hero-primary);
          filter: brightness(85%);
        }

        a .title {
          width: 100%;
          text-align: center;
          border-top: 2px solid var(--hero-primary);
        }

        .card a {
          display: flex;
          flex-direction: column;
          align-items: center;
        }
      `,
    ];
  }
}
