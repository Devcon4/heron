import { html, LitElement } from 'lit';
import { customElement } from 'lit/decorators';

@customElement('hero-current')
export default class HeroCurrentElement extends LitElement {
  render() {
    return html`<div class="current flex"><h3>Current</h3></div>`;
  }
}
