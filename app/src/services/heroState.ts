import { BehaviorSubject, tap } from 'rxjs';
import { fromFetch } from 'rxjs/fetch';
import { HashTable, Lookup, order } from './arrayUtils';
import { HandleRequest } from './fetchUtils';

export type Hero = {
  id: string;
  name: string;
  type: string;
  description: string;
};

export type HeroListItem = {
  id: string;
  name: string;
};

export type HeroAbility = {
  id: string;
  heroid: string;
  name: string;
  description: string;
  isultimate: boolean;
};

export type GetHeroesResponse = {
  list: HeroListItem[];
  count: number;
};

export type GetHeroResponse = {
  hero: Hero;
  abilities: HeroAbility[];
};

export class HeroState {
  heroes = new BehaviorSubject<HeroListItem[]>([]);
  heroDetails = new BehaviorSubject<Hero>(undefined);
  heroAbilities = new BehaviorSubject<HeroAbility[]>([]);
  heroHashLookup = new BehaviorSubject<HashTable>({ inverse: {}, lookup: {} });

  private mapHeroHashes(list: HeroListItem[]): HashTable {
    const lookup: Lookup = {};

    for (let hero of list) {
      let [first, second] = hero.id.split('-');
      if (lookup[first]) first += `-${second}`;
      lookup[first] = hero.id;
    }

    const inverse: Lookup = Object.fromEntries(
      Object.entries(lookup).map((a) => a.reverse())
    );
    return { lookup, inverse };
  }

  getHeroes() {
    fromFetch('./api/hero')
      .pipe(
        HandleRequest<GetHeroesResponse>(),
        tap((r) => this.heroes.next(r.list.sort(order((h) => h.name, 'Asc')))),
        tap((r) => this.heroHashLookup.next(this.mapHeroHashes(r.list)))
      )
      .subscribe();
  }

  getHeroDetails(hashid: string) {
    fromFetch(`./api/hero/${hashid}`)
      .pipe(
        HandleRequest<GetHeroResponse>(),
        tap((r) => this.heroDetails.next(r.hero)),
        tap((r) => this.heroAbilities.next(r.abilities))
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
