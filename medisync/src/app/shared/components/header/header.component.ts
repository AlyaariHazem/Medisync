import { Component } from '@angular/core';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrl: './header.component.scss'
})
export class HeaderComponent {
  isMenuActive: boolean = false;

  toggleMenu() {
    this.isMenuActive = !this.isMenuActive;
  }
  
}
