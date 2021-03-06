import { css, html, LitElement } from 'lit';
import { customElement, query, state } from 'lit/decorators.js';
import { RouterSlot } from 'router-slot';
import 'router-slot/router-slot';
import { async } from './services/decoratorUtils';
import heroState from './services/heroState';
import releaseState from './services/releaseState';
import { routes } from './services/routes';
import themeState, { ThemeType } from './services/themeState';
import { flexHostStyles, globalStyles } from './styles/globalStyles';

@customElement('hero-app')
export default class AppElement extends LitElement {
  @state()
  @async(themeState.theme)
  colorTheme: ThemeType;

  @query('router-slot')
  $routerSlot!: RouterSlot;

  toggleThemeAction = () => themeState.toggleTheme();

  firstUpdated() {
    releaseState.getReleases();
    heroState.getHeroes();
    this.$routerSlot.add(routes);
  }

  render() {
    return html`<div class="app flex">
      <div class="header">
        <a href="/gallery"><h1>🐦 Heron</h1></a>
        <mwc-icon-button
          id="theme-btn"
          @click=${this.toggleThemeAction}
          .icon="${this.colorTheme === 'dark' ? 'light_mode' : 'nights_stay'}"
        ></mwc-icon-button>
      </div>
      <!-- <div class="box-list">
        <div class="box box-1">primary</div>
        <div class="box box-2">primary variant</div>
        <div class="box box-3">secondary</div>
        <div class="box box-4">secondary variant</div>
        <div class="box box-5">background</div>
        <div class="box box-6">surface</div>
        <div class="box box-7">error</div>
      </div> -->
      <router-slot class="flex"></router-slot>
    </div>`;
  }

  static get styles() {
    return [
      globalStyles,
      flexHostStyles,
      css`
        .app {
          display: flex;
        }

        .header {
          display: flex;
          justify-content: space-between;
          padding: 12px;
        }

        .box-list {
          max-width: 1024px;
          align-self: center;
          display: flex;
          flex-direction: row;
          flex-wrap: wrap;
          justify-content: center;
        }

        .box {
          width: calc(100% / 4 - 48px);
          aspect-ratio: 1;
          border-radius: 5px;
          padding: 12px;
          margin: 12px;
          filter: drop-shadow(0 3px 3px rgba(0, 0, 0, 0.2));
        }

        @media (max-width: 512px) {
          .box {
            width: 100%;
          }
        }

        .box-1 {
          background-color: var(--hero-primary);
          color: var(--hero-on-primary);
        }
        .box-2 {
          background-color: var(--hero-primary-variant);
          color: var(--hero-on-primary);
        }
        .box-3 {
          background-color: var(--hero-secondary);
          color: var(--hero-on-secondary);
        }
        .box-4 {
          background-color: var(--hero-secondary-variant);
          color: var(--hero-on-secondary);
        }
        .box-5 {
          background-color: var(--hero-background);
          color: var(--hero-on-background);
        }
        .box-6 {
          background-color: var(--hero-surface);
        }
        color: var(--hero-on-surface);
        .box-7 {
          background-color: var(--hero-error);
          color: var(--hero-on-error);
        }
      `,
    ];
  }
}
