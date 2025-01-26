import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators, FormsModule, ReactiveFormsModule } from '@angular/forms';
import { AuthAPIService } from '../../auth/authAPI.service';
import { Router } from '@angular/router';
import { User } from '../../core/models/user.model';
import { CardModule } from 'primeng/card';
import { CommonModule } from '@angular/common';
import { ButtonModule } from 'primeng/button';
import { PasswordModule } from 'primeng/password';
import { MessageModule } from 'primeng/message';
import { InputTextModule } from 'primeng/inputtext';
import { SharedModule } from 'primeng/api';
import { HeaderComponent } from '../header/header.component';
import { FooterComponent } from '../footer/footer.component';

@Component({
  selector: 'app-login',
  standalone:true,
  imports: [FormsModule,SharedModule,HeaderComponent,FooterComponent, ButtonModule,CommonModule,CardModule,PasswordModule,MessageModule,ReactiveFormsModule,InputTextModule],
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent implements OnInit {
  loginForm: FormGroup;
  errorMessage: string = '';
  isSubmitted: boolean = false;

  constructor(
    private fb: FormBuilder,
    private authService: AuthAPIService,
    private router: Router
  ) {
    this.loginForm = this.fb.group({
      username: ['', Validators.required],
      password: ['', Validators.required]
    });
  }

  ngOnInit(): void {
    // Any initialization logic can go here
  }

  onSubmit(): void {
    this.isSubmitted = true;
    this.errorMessage = '';

    if (this.loginForm.invalid) {
      return;
    }

    const user: User = this.loginForm.value;
    this.authService.login(user).subscribe({
      next: (response) => {
        this.router.navigateByUrl('user');
      },
      error: (error) => {
        this.errorMessage = 'Invalid username or password. Please try again.';
        console.error('Login error:', error);
      }
    });
  }
}
