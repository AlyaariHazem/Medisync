import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators, FormsModule, ReactiveFormsModule } from '@angular/forms';
import { CardModule } from 'primeng/card';
import { CommonModule } from '@angular/common';
import { ButtonModule } from 'primeng/button';
import { PasswordModule } from 'primeng/password';
import { MessageModule } from 'primeng/message';
import { InputTextModule } from 'primeng/inputtext';
import { SharedModule } from 'primeng/api';
import { HeaderComponent } from '../../components/user/header/header.component';
import { FooterComponent } from '../footer/footer.component';
@Component({
  selector: 'app-register',
  standalone: true,
  imports: [FormsModule,SharedModule, ButtonModule,CommonModule,CardModule,PasswordModule,MessageModule,ReactiveFormsModule,InputTextModule],
  templateUrl: './register.component.html',
  styleUrl: './register.component.scss'
})
export class RegisterComponent {

}
