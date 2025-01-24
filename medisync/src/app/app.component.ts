import { Component } from '@angular/core';
import { ShardModule } from './shared/shard.module';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [ ShardModule],
  templateUrl: './app.component.html',
  styleUrl: './app.component.scss'
})
export class AppComponent {
  title = 'medisync';
}
