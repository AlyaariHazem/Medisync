import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { FormsModule,  ReactiveFormsModule } from '@angular/forms';

import { HeaderComponent } from './components/header/header.component';
import { FooterComponent } from './components/footer/footer.component';

const components=[
  HeaderComponent,
  FooterComponent
];

const modules=[
   FormsModule,
    CommonModule,
    ReactiveFormsModule,
    RouterModule
]

@NgModule({
 declarations: [...components],
 imports: [...modules],
 exports:[
    ...modules,
    ...components
 ]
})
export class ShardModule {}
