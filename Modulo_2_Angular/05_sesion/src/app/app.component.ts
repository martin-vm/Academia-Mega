import { Component, model } from '@angular/core';
import { RouterOutlet } from '@angular/router';
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
    ],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {

  rolUsuario = "admin";

  tareaImportante = true;
  isUrgente = false;

}

