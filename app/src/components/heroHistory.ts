import { html, LitElement } from 'lit';
import { customElement } from 'lit/decorators';

@customElement('hero-history')
export default class HeroHistoryElement extends LitElement {
  render() {
    return html`<div class="history flex"><h3>History</h3></div>`;
  }
}
