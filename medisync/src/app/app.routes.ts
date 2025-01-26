import { Routes } from '@angular/router';

import { MedicationDetailComponent } from './components/medication-detail/medication-detail.component';
import { AuthGuard } from './core/guards/auth.guard';

export const routes: Routes = [
  { path: '', redirectTo: '/public', pathMatch: 'full' },

  {
    path: 'public',
    loadChildren: () => import('./components/public/public.module').then(m => m.PublicModule)
  },

  { path: 'medications/:id', component: MedicationDetailComponent },

  {
    path: 'user',
    loadChildren: () => import('./components/user/user.module').then(m => m.UserModule),
    canActivate: [AuthGuard],
  },

  { path: '**', redirectTo: '/public/notfound', pathMatch: 'full' }
];