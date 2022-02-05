import { css, customElement, html, LitElement } from 'lit-element';
import { switchMap, tap } from 'rxjs';
import { fromFetch } from 'rxjs/fetch';
import { flexHostStyles, globalStyles } from '../globalStyles';
@customElement('hro-hero-list')
export class HeroListElement extends LitElement {

  data = fromFetch('./api/weatherforecast').pipe(switchMap(r => r.json()), tap(d => console.log(d))).subscribe()

  render() {
    return html`<div class="hero-list hro-flex">
      <div class="heading">
        <h2>Gallery</h2>
      </div>
      <div class="list">
        <div class="card">
          <h3 class="title">Ashe</h3>
          <p class="description">A gunslinger! Lorem ipsum dolor sit amet consectetur adipisicing elit. Rerum quam facere laborum? Tempora sapiente, laboriosam eum aspernatur doloribus reprehenderit veritatis, voluptatibus quam sed beatae ea nemo. In pariatur optio magni vel ea a numquam mollitia non quo incidunt molestiae rem quisquam, laborum, est voluptas. Ullam, eaque nostrum. Quis, fugiat temporibus!</p>
        </div>
      </div>
    </div>`;
  }

  static get styles() {
    return [globalStyles, flexHostStyles, css`
      .hero-list {
        display: flex;
        align-self: center;
        
        max-width: 1080px;
        width: 100%;
      }
      
      .heading {
        padding: 24px;
        background-color: var(--hroMain);

        margin-bottom: 32px;

        filter: drop-shadow(0 5px 6px rgba(0,0,0,.2));
      }

      .list {
        display: flex;

      }

      .card {
        display: flex;
        flex-direction: column;
        padding: 32px;
        background-color: var(--hroLightAccent);
        filter: drop-shadow(0 5px 6px rgba(0,0,0,.2));
      }

    `];
  }
}