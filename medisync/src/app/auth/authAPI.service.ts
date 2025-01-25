import { Injectable, inject } from '@angular/core';
import { Observable, tap } from 'rxjs';
import { Router } from '@angular/router';
import { BackendAspService } from '../environments/backend-asp.service';
import { User } from '../core/models/user.model';

@Injectable({
  providedIn: 'root',
})
export class AuthAPIService {
  private API = inject(BackendAspService);

  constructor(public router: Router) {}

  login(user: User): Observable<{ token: string }> {
    return this.API.http.post<{ token: string }>(`${this.API.baseUrl}/account/login`, user).pipe(
      tap((response) => {
        if (response?.token) {
          localStorage.setItem('token', response.token);
        }
      })
    );
  }

  register(user: User): Observable<any> {
    return this.API.http.post(`${this.API.baseUrl}/account/register`, user);
  }

  logout() {
    localStorage.removeItem('token');
    this.router.navigate(['/login']);
  }
}