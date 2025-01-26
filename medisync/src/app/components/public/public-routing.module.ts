import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { NavigateComponent } from './navigate/navigate.component';
import { HomeComponent } from './home/home.component';
import { LoginComponent } from '../../auth/login/login.component';
import { NotFoundComponent } from '../not-found/not-found.component';

const routes: Routes = [
  {
     path: '', component: NavigateComponent,
     children: [
        {path:'',component:HomeComponent},
       { path: 'home', component: HomeComponent },
       { path: 'login', component: LoginComponent },
       { path: 'notfound', component: NotFoundComponent },
       { path: '**', redirectTo: 'notfound', pathMatch: 'full' }
     ]
   },
   {path:'',redirectTo:'/public/home',pathMatch:'full'}
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class PublicRoutingModule { }
