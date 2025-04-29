import { Component, model } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { saludo } from './Components/saludo/saludo.component';
import { CardComponent } from './Components/card/card.component';
import { TarjetaComponent } from "./Components/tarjeta/tarjeta.component";
import { CommonModule } from '@angular/common';
import { TodoComponent } from './Components/todo/todo.component';


@Component({
  selector: 'app-root',
  imports: [
      RouterOutlet, 
      saludo, 
      CardComponent, 
      TarjetaComponent, 
      CommonModule, TodoComponent
      
    ],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  isVisible = true;
  frutas = ['Manzana', 'Platano', 'Naranja', 'Uva', 'Piña'];
}

interface carModel {
  brand:string;
  model:string;
  year?:number;
}