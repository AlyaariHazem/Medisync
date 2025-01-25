import { Routes } from '@angular/router';

import { HomeComponent } from './components/home/home.component';
import { LoginComponent } from './components/login/login.component';
import { RegisterComponent } from './components/register/register.component';
import { MedicationsComponent } from './components/medications/medications.component';
import { MedicationDetailComponent } from './components/medication-detail/medication-detail.component';
import { NotFoundComponent } from './components/not-found/not-found.component';
import { InteractionsComponent } from './components/interactions/interactions.component';

export const routes: Routes = [
    { path: '', redirectTo: '/home', pathMatch: 'full' },
    
    // Public Pages
    { path: 'home', component: HomeComponent },
    { path: 'medications', component: MedicationsComponent },
    { path: 'medications/:id', component: MedicationDetailComponent },
    
    { path: 'login', component: InteractionsComponent },
    { path: 'register', component: MedicationsComponent },
    
    { path: '**', component: NotFoundComponent }
  ];