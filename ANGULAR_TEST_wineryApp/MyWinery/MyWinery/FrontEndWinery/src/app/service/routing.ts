import { NgModule } from '@angular/core';
import { Routes,  RouterModule } from '@angular/router';
import { HomeComponent } from '../component/home/home.component';
import { WineryComponent } from '../component/winery/winery.component';


const routes: Routes=[
    {path: 'Home', component: HomeComponent },
    {path: 'Winery', component: WineryComponent},
    {path: '', redirectTo: 'Home', pathMatch: 'full'},
    {path: '**', redirectTo: 'Home', pathMatch: 'full'}
    ];

    
@NgModule ({
    imports: [RouterModule.forRoot(routes)],
    exports: [RouterModule]
})

export class RoutingModule {}

export const RoutingComponents = [ HomeComponent, WineryComponent ]