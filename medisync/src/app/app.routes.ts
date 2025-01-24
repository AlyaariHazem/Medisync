import { Routes } from '@angular/router';

import { HomeComponent } from './components/home/home.component';
import { LoginComponent } from './components/login/login.component';
import { RegisterComponent } from './components/register/register.component';
import { MedicationComponent } from './components/medication/medication.component';
import { MedicationDetailComponent } from './components/medication-detail/medication-detail.component';
import { NotFoundComponent } from './components/not-found/not-found.component';

export const routes: Routes = [
    { path: '', redirectTo: '/home', pathMatch: 'full' },
    
    // Public Pages
    { path: 'home', component: HomeComponent },
    { path: 'medications', component: MedicationComponent },
    { path: 'medications/:id', component: MedicationDetailComponent },
    
    { path: 'login', component: LoginComponent },
    { path: 'register', component: RegisterComponent },
    
    { path: '**', component: NotFoundComponent }
  ];