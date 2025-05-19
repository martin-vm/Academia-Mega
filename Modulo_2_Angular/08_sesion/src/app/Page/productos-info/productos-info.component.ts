import { Component } from '@angular/core';
import { ProductosComponent } from '../../Components/productos/productos.component';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-productos-info',
  imports: [ ProductosComponent ,CommonModule ],
  templateUrl: './productos-info.component.html',
  styleUrl: './productos-info.component.css'
})
export class ProductosInfoComponent {
  items = [
    {id: 1 , nombre:"Producto a ", descripcion:"Descripcion del producto a", precio: 100},
    {id: 2 , nombre:"Producto b ", descripcion:"Descripcion del producto b", precio: 200},
    {id: 3 , nombre:"Producto c ", descripcion:"Descripcion del producto c", precio: 300},
    {id: 4 , nombre:"Producto d ", descripcion:"Descripcion del producto d", precio: 400},
  ]

  itemSeleccionado: any = null;

  seleccionarItem(item : any){
    this.itemSeleccionado = item;
  }

}
