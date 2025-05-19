import { Component, EventEmitter, Input, Output } from '@angular/core';

@Component({
  selector: 'app-productos',
  imports: [],
  templateUrl: './productos.component.html',
  styleUrl: './productos.component.css'
})
export class ProductosComponent {
   @Input() info:any ;
  //  {
  //    id:0,
  //    nombre: '',
  //    descripcion: '',
  //    precio: 0
  //  };

   @Output() seleccionado = new EventEmitter();

   seleccionar(){
    this.seleccionado.emit(this.info);

   }
}
