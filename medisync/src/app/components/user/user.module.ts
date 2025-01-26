import { NgModule } from '@angular/core';
import { InputTextModule } from 'primeng/inputtext';
import { InputTextareaModule } from 'primeng/inputtextarea';
import { MultiSelectModule } from 'primeng/multiselect';
import { CardModule } from 'primeng/card';
import { RouterModule } from '@angular/router';

import { UserRoutingModule } from './user-routing.module';
import { FooterComponent } from '../../auth/footer/footer.component';
import { HeaderComponent } from './header/header.component';
import { ShardModule } from '../../shared/shard.module';
import { InteractionsComponent } from './interactions/interactions.component';
import { MedicationsComponent } from './medications/medications.component';
import { NavigateComponent } from './navigate/navigate.component';
import { HomeComponent } from './home/home.component';

const components = [
  FooterComponent,
  HeaderComponent,
  InteractionsComponent,
  MedicationsComponent,
  HomeComponent,
  NavigateComponent
]
const models = [
  UserRoutingModule,
  ShardModule,
  CardModule,
  RouterModule,
  InputTextModule,
  InputTextareaModule,
  MultiSelectModule,
]
@NgModule({
  declarations: components,
  imports: models,
  exports: [...components, ...models]
})
export class UserModule { }
