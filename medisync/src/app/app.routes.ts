import { Routes } from '@angular/router';

import { HomeComponent } from './components/home/home.component';
import { MedicationDetailComponent } from './components/medication-detail/medication-detail.component';
import { NotFoundComponent } from './components/not-found/not-found.component';
import { LoginComponent } from './auth/login/login.component';
import { InteractionsComponent } from './components/user/interactions/interactions.component';
import { MedicationsComponent } from './components/user/medications/medications.component';
import { RegisterComponent } from './auth/register/register.component';

export const routes: Routes = [
  { path: '', redirectTo: '/home', pathMatch: 'full' },

  // Public Pages
  { path: 'home', component: HomeComponent },
  { path: 'medications/:id', component: MedicationDetailComponent },
  { path: 'login', component: LoginComponent },
  {
    path: 'user', children: [
      {path:'',component:InteractionsComponent},
      { path: 'home', component: InteractionsComponent },
      { path: 'interaction', component: InteractionsComponent },
      { path: 'medication', component: MedicationsComponent },
      { path: 'register', component: RegisterComponent },
      { path: 'notfound', component: NotFoundComponent },
      {path:'**',redirectTo:'notfound',pathMatch:'full'}
    ]
  },
  { path: '**', component: NotFoundComponent }
];