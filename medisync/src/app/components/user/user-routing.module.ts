import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { InteractionsComponent } from './interactions/interactions.component';
import { MedicationsComponent } from './medications/medications.component';
import { RegisterComponent } from '../../auth/register/register.component';
import { NotFoundComponent } from '../not-found/not-found.component';
import { NavigateComponent } from './navigate/navigate.component';
import { HomeComponent } from './home/home.component';

const routes: Routes = [
  {
    path: '', // '/user'
    component: NavigateComponent,
    // canActivate: [AuthGuard], // Protect all child routes (if AuthGuard is implemented)
    children: [
      { path: 'home', component: HomeComponent },
      { path: 'interaction', component: InteractionsComponent },
      { path: 'medication', component: MedicationsComponent },
      { path: 'register', component: RegisterComponent },
      { path: 'notfound', component: NotFoundComponent },
      { path: '**', redirectTo: 'home', pathMatch: 'full' }
    ]
  },
  {path:'**',redirectTo:'/user/home',pathMatch:'full'}
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class UserRoutingModule { }
