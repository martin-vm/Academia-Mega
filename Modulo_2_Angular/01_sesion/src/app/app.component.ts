import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { saludo } from './Components/saludo/saludo.component';
import { CardComponent } from './Components/card/card.component';

@Component({
  selector: 'app-root',
  imports: [RouterOutlet , saludo , CardComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'Bienvenido a mi primer ejemplo con Angular';
  profesion = 'Desarrollador de Software';
  puesto = 'Coordinador de Interfaces';
  empresa = 'MEGACACABLE';
  nombre = 'Martín Eduardo Villaseñor Merino';

}
