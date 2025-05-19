import { Routes } from '@angular/router';
import { ProductManagerComponent } from './Components/product-manager/product-manager.component';
import { CardComponent } from './Components/card/card.component';
import { TodoComponent } from './Components/todo/todo.component';
import { HomeComponent } from './Page/home/home.component';
import { ErrorComponent } from './Page/error/error.component';
import { TarjetaComponent } from './Components/tarjeta/tarjeta.component';
import { ProductosInfoComponent } from './Page/productos-info/productos-info.component';

export const routes: Routes = [

    {
        path: '',
        component: ProductosInfoComponent
    },
    {
        path: 'home',
        component: HomeComponent
    },
        
    {
        path: 'gestor',
        component: ProductManagerComponent
    },
    {
        path:'card',
        component: CardComponent
    },
    {
        path:'todo',
        component: TodoComponent

    },
    {
        path: 'tarjeta',
        component: TarjetaComponent
    },
    
    {
        path:'**',
        component:ErrorComponent
    }
    


];
