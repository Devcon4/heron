import { BehaviorSubject, tap } from 'rxjs';
import { fromFetch } from 'rxjs/fetch';
import { HandleRequest } from './fetchUtils';

export type Hero = {
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
  list: Hero[];
  count: number;
};

export type GetHeroResponse = {
  hero: Hero;
  abilities: HeroAbility[];
};

export type Lookup = { [key: string]: string };
export type HashTable = { lookup: Lookup; inverse: Lookup };
export class HeroState {
  heroes = new BehaviorSubject<Hero[]>([]);
  heroDetails = new BehaviorSubject<Hero>(undefined);
  heroAbilities = new BehaviorSubject<HeroAbility[]>([]);
  heroHashLookup = new BehaviorSubject<HashTable>({ inverse: {}, lookup: {} });

  private mapHeroHashes(list: Hero[]): HashTable {
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
    fromFetch('./api/heroes')
      .pipe(
        HandleRequest<GetHeroesResponse>(),
        tap((r) => this.heroes.next(r.list)),
        tap((r) => this.heroHashLookup.next(this.mapHeroHashes(r.list)))
      )
      .subscribe();
  }

  getHeroDetails(hashid: string) {
    fromFetch(`./api/heroes/${hashid}`)
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
