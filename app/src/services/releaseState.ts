import { BehaviorSubject, tap } from 'rxjs';
import { fromFetch } from 'rxjs/fetch';
import { HandleRequest } from './fetchUtils';

export type Release = {
  id: string;
  title: string;
  releaseDate: Date;
};

export type HeroUpdate = {
  id: string;
  heroAbilityId: string;
  releaseId: string;
  developerComments: string;
  changeNotes: string;
};

export type GetReleasesResponse = {
  list: Release[];
  count: number;
};

export type GetReleaseResponse = {
  release: Release;
  heroUpdates: HeroUpdate[];
};

export class ReleaseState {
  releases = new BehaviorSubject<Release[]>([]);
  releaseDetails = new BehaviorSubject<Release>(undefined);
  heroUpdates = new BehaviorSubject<HeroUpdate[]>([]);

  getReleases() {
    fromFetch('./api/release')
      .pipe(
        HandleRequest<GetReleasesResponse>(),
        tap((r) => this.releases.next(r.list)),
        tap((r) => this.getRelease(r.list[0].id))
      )
      .subscribe();
  }

  getRelease(id: string) {
    fromFetch(`./api/release/${id}`)
      .pipe(
        HandleRequest<GetReleaseResponse>(),
        tap((r) => this.releaseDetails.next(r.release)),
        tap((r) => this.heroUpdates.next(r.heroUpdates))
      )
      .subscribe();
  }

  clearReleaseDetails() {
    this.releaseDetails.next(undefined);
  }
}

// Singleton setup.
const releaseState = new ReleaseState();
export default releaseState;
