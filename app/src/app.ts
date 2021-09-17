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

const routes: Array<IRoute> = [
  {
    path: 'gallery',
    component: async () => (await import('./components/heroList.component')).HeroListElement
  },
  {
    path: '**',
    redirectTo: 'gallery',
    pathMatch: 'full'
  },
  
];

@customElement('hro-app')
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
    return html`<div class="app hro-flex">
      <router-slot class="hro-flex"></router-slot>
    </div>`;
  }

  static get styles() {
    return [globalStyles, flexHostStyles, css``];
  }
}
