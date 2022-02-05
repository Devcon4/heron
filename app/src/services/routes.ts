import { IRoute } from 'router-slot';
import heroState from './heroState';

export const routes: Array<IRoute> = [
  {
    path: 'home',
    component: async () => await import('../components/example'),
  },
  {
    path: 'gallery',
    component: async () => await import('../components/gallery'),
    setup: () => heroState.getHeroes(),
  },
  {
    path: 'herodetails/:id',
    component: async () => await import('../components/heroDetails'),
    setup: (_, info) => {
      heroState.clearHeroDetails();
      heroState.getHeroDetails(info.match.params.id);
    },
  },
  {
    path: '**',
    redirectTo: 'gallery',
    pathMatch: 'full',
  },
];
