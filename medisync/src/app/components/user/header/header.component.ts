import { Component, inject } from '@angular/core';
import { RouterModule } from '@angular/router';
import { AuthAPIService } from '../../../auth/authAPI.service';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrl: './header.component.scss'
})
export class HeaderComponent {
  isMenuActive: boolean = false;
  authAPI=inject(AuthAPIService);
  toggleMenu() {
    this.isMenuActive = !this.isMenuActive;
  }
  logOut():void{
    this.authAPI.logout();
  }
}
