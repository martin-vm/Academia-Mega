import { Routes } from '@angular/router';
import { ProductManagerComponent } from './Components/product-manager/product-manager.component';
import { CardComponent } from './Components/card/card.component';
import { TodoComponent } from './Components/todo/todo.component';
import { HomeComponent } from './Page/home/home.component';
import { ErrorComponent } from './Page/error/error.component';
import { TarjetaComponent } from './Components/tarjeta/tarjeta.component';
import { ProductosInfoComponent } from './Page/productos-info/productos-info.component';
//import { ServicePageComponent } from './Page/service-page/service-page.component';
import { FormularioComponent } from './Page/formulario/formulario.component';
import { ProductListComponent } from './Page/product-list/product-list.component';
import { ServicePageComponent } from './Page/service-page/service-page.component';
import { UsuariosComponent } from './Page/usuarios/usuarios.component';

export const routes: Routes = [
    {
        path: '',
        component: UsuariosComponent
    },    
    {
        path: 'httpcli',
        component: ProductListComponent
    },        
    {
        path: 'formulario',
        component: FormularioComponent
    },    

    {
        path: 'servicio',
        component: ServicePageComponent
    },    
   
    {
        path: 'Componentes',
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
