import { Component } from '@angular/core';
import { setAlternateWeakRefImpl } from '@angular/core/primitives/signals';
import { FormsModule } from '@angular/forms';


@Component({
  selector: 'app-card',
  imports: [FormsModule],
  templateUrl: './card.component.html',
  styleUrl: './card.component.css'
})
export class CardComponent {
  title= "Título de la card";
  contenido = "Esto es una card que vamos a estar trabajando";
  botonText="Conocer más";
  nombre = "";


  img = "https://picsum.photos/640/640?r" + Math.random();
  
  mostrarAlerta(){
    alert("Hola Martín");
  }
}
