import '@material/mwc-circular-progress-four-color';
import { css, html, LitElement } from 'lit';
import { customElement } from 'lit/decorators.js';
import { globalStyles } from '../styles/globalStyles';

@customElement('hero-loading')
export class LoadingElement extends LitElement {
  render() {
    return html`<mwc-circular-progress-four-color density="8" indeterminate />`;
  }

  static get styles() {
    return [
      globalStyles,
      css`
        :host {
          display: flex;
          flex: 1;
          justify-content: center;
          align-items: center;
        }
      `,
    ];
  }
}

export function loading() {
  return html`<hero-loading />`;
}
