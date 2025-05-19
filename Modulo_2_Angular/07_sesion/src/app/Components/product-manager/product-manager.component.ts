import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-product-manager',
  imports: [CommonModule , FormsModule],
  templateUrl: './product-manager.component.html',
  styleUrl: './product-manager.component.css'
})
export class ProductManagerComponent {
  categoriaSeleccionada: string = "alimentos";
  productos = {
    electronica: [
      {nombre: "Laptop", precio:1200, disponible:true, descuento: 10},
      {nombre: "Smartphone", precio:800, disponible:false, descuento: 0},
    ],
    ropa:[
      {nombre: "Camisa", precio:30, disponible:true, descuento: 0},
      {nombre: "Jeans", precio:50, disponible:true, descuento: 0},
    ],
    alimentos:[
      {nombre: "Carnes", precio:15, disponible:true, descuento: 0},
      {nombre: "Verduras", precio:10, disponible:true, descuento: 10},
    ]
}

seleccionaCategoria(categoria: string){
  this.categoriaSeleccionada = categoria;
}


}
