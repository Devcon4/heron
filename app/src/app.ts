import {
  css,
  customElement,
  html,
  LitElement,
  PropertyValues,
  query
} from 'lit-element';
import { IRoute, queryParentRouterSlot, RouterSlot } from 'router-slot';
import { flexHostStyles, globalStyles } from './globalStyles';

const routes: Array<IRoute> = [];

@customElement('hero-app')
export class AppElement extends LitElement {
  @query('router-slot') $routerSlot: RouterSlot;

  get data() {
    return queryParentRouterSlot(this);
  }

  firstUpdated(props: PropertyValues) {
    super.firstUpdated(props);
    this.$routerSlot.add(routes);
  }

  render() {
    return html`<div cass="app hero-flex">
      <h1 class="text">I Work still!</h1>
      <router-slot class="hero-flex"></router-slot>
    </div>`;
  }

  static get styles() {
    return [globalStyles, flexHostStyles, css``];
  }
}
