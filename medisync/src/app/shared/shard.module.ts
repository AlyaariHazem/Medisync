import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { FormsModule,  ReactiveFormsModule } from '@angular/forms';

import { HeaderComponent } from './components/header/header.component';
import { FooterComponent } from './components/footer/footer.component';
import { DropdownModule } from 'primeng/dropdown';
import { ButtonModule } from 'primeng/button';
import { TableModule } from 'primeng/table';

const components=[
  HeaderComponent,
  FooterComponent
];

const modules=[
   FormsModule,
    CommonModule,
    ReactiveFormsModule,
    RouterModule,
    DropdownModule,
    ButtonModule,
    TableModule,
    
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
