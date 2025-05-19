import { Injectable } from '@angular/core';
import { retryWhen } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class DataService {

  // constructor() { }
  private message = "Hola desde el servicio que acabo de crear";

  getMessage(){
    return this.message;
  }

  setMessage( newMessage: string ){
    this.message = newMessage;
  }
    
  
}
