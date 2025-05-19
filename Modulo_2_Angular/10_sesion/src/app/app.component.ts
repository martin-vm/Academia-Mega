import { Component, model } from '@angular/core';
import { RouterLink, RouterOutlet } from '@angular/router';
import { saludo } from './Components/saludo/saludo.component';
import { CardComponent } from './Components/card/card.component';
import { TarjetaComponent } from "./Components/tarjeta/tarjeta.component";
import { CommonModule } from '@angular/common';
import { TodoComponent } from './Components/todo/todo.component';
import { ProductManagerComponent } from './Components/product-manager/product-manager.component';
@Component({
  selector: 'app-root',
  imports: [
      RouterOutlet, 
      saludo, 
      CardComponent, 
      TarjetaComponent, 
      CommonModule, TodoComponent , ProductManagerComponent      
      , RouterLink
    ],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  //isVisible = true;
  //frutas = ['Mazana','Platano','Naranja','Uva','Piña' , 'Arrayan'];

  rolUsuario = "admin";

  tareaImportante = true;
  isUrgente = false;

}

