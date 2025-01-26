import { Component } from '@angular/core';
import { RouterModule } from '@angular/router';
import { HeaderComponent } from '../../auth/header/header.component';
import { FooterComponent } from '../../auth/footer/footer.component';

@Component({
  selector: 'app-not-found',
  standalone:true,
  imports:[RouterModule,HeaderComponent,FooterComponent],
  templateUrl: './not-found.component.html',
  styleUrl: './not-found.component.scss'
})
export class NotFoundComponent {

}
