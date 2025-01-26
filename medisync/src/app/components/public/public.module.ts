import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CardModule } from 'primeng/card';
import { FormsModule } from '@angular/forms';
import { MultiSelectModule } from 'primeng/multiselect';
import { ButtonModule } from 'primeng/button';
import { RouterModule } from '@angular/router';

import { PublicRoutingModule } from './public-routing.module';
import { ShardModule } from '../../shared/shard.module';
import { HomeComponent } from './home/home.component';
import { NavigateComponent } from './navigate/navigate.component';
import { HeaderComponent } from './header/header.component';
import { FooterComponent } from '../../shared/components/footer/footer.component';

const components=[
HomeComponent,
NavigateComponent,
HeaderComponent,
FooterComponent
]
const models=[
  FormsModule,
  MultiSelectModule,
  ShardModule, 
  ButtonModule,
  RouterModule,
  CommonModule,
  CardModule,
  PublicRoutingModule
]

@NgModule({
  declarations: components,
  imports: models,
  exports:[...components,...models]
})
export class PublicModule { }
