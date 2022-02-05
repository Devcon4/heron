import { BehaviorSubject, tap } from 'rxjs';
import { fromFetch } from 'rxjs/fetch';
import { HandleRequest } from './fetchUtils';

export type Hero = {
  id: string;
  name: string;
};

export type GetHeroesResponse = {
  list: Hero[];
  count: number;
};

export type GetHeroResponse = {
  hero: Hero;
};

export class HeroState {
  heroes = new BehaviorSubject<Hero[]>([]);
  heroDetails = new BehaviorSubject<Hero>(undefined);

  getHeroes() {
    fromFetch('./api/heroes')
      .pipe(
        HandleRequest<GetHeroesResponse>(),
        tap((r) => this.heroes.next(r.list))
      )
      .subscribe();
  }

  getHeroDetails(id: string) {
    fromFetch(`./api/heroes/${id}`)
      .pipe(
        HandleRequest<GetHeroResponse>(),
        tap((r) => this.heroDetails.next(r.hero))
      )
      .subscribe();
  }

  clearHeroDetails() {
    this.heroDetails.next(undefined);
  }
}

// Singleton setup.
const heroState = new HeroState();
export default heroState;
