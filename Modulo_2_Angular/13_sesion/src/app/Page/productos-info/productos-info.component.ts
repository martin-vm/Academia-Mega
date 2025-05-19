import { Component } from '@angular/core';
import { ProductosComponent } from '../../Components/productos/productos.component';
import { CommonModule } from '@angular/common';
import { DetallesComponent } from '../../Components/detalles/detalles.component';

@Component({
  selector: 'app-productos-info',
  imports: [ ProductosComponent ,CommonModule , DetallesComponent ],
  templateUrl: './productos-info.component.html',
  styleUrl: './productos-info.component.css'
})
export class ProductosInfoComponent {
  //Simulaciónde API de productos
  items = [
    {id: 1 , nombre:"Calcetines negros caballero", descripcion:"Paquete de calcentines color negro caballero", precio: 100},
    {id: 2 , nombre:"Pantalón levis dama 9 ", descripcion:"Pantalón levis dama talla 9", precio: 200},
    {id: 3 , nombre:"Lavador Mabe 11Kg", descripcion:"Lavadora marca mabe super lavandera", precio: 300},
    {id: 4 , nombre:"Bicicleta BMX ", descripcion:"Bicicleta de montaña marca duck hunt r26", precio: 400},
  ]

  itemSeleccionado: any = null;

  seleccionarItem(item : any){
    this.itemSeleccionado = item;
  }

}
