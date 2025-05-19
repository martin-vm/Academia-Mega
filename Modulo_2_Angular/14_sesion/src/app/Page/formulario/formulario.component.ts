import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';


@Component({
  selector: 'app-formulario',
  imports: [ FormsModule , CommonModule],
  templateUrl: './formulario.component.html',
  styleUrl: './formulario.component.css'
})
export class FormularioComponent {

  usuario = {
    nombre: '',
    email: '',
    edad: null
  }
  //Función que se dispara
  onSubmit(){
    console.log("Datos de formulario" , this.usuario)
    alert("Formulario enviada correctamente")
  }

  
}
