import { Injectable } from '@angular/core';
import { CanActivate, ActivatedRouteSnapshot, RouterStateSnapshot, Router } from '@angular/router';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class AuthGuard implements CanActivate {
  constructor(private router: Router) {}

  canActivate(
    route: ActivatedRouteSnapshot,
    state: RouterStateSnapshot
  ): Observable<boolean> | Promise<boolean> | boolean {
    const isAuthenticated = this.checkAuthentication(); // Your authentication logic here
    if (!isAuthenticated) {
      this.router.navigate(['/public']); // Redirect to public if not authenticated
    }
    return isAuthenticated;
  }

  private checkAuthentication(): boolean {
    // Add your actual authentication logic here
    // Example: return Boolean(localStorage.getItem('userToken'));
    const token=localStorage.getItem('medisync');
    if(token){
      return true;
    }
    return false; // Example: Not authenticated by default
  }
}
