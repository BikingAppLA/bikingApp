import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { MatMenuModule } from '@angular/material/menu';
import { AppComponent } from './app.component';
import { SideNavComponent } from './component/SideNav/SideNav.component';
import { HomeComponent } from './component/home/home.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MatNativeDateModule } from '@angular/material/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { MatSidenavModule } from '@angular/material/sidenav';
import { MatIconModule } from '@angular/material/icon';
import { MatToolbarModule } from '@angular/material/toolbar';
import { MatListModule } from '@angular/material/list';
import { HttpClientModule } from '@angular/common/http';
import { WineryComponent } from './component/winery/winery.component';
import { WineService } from './service/wine-service';
import { LocationStrategy, HashLocationStrategy, CommonModule } from '@angular/common';
import { RoutingModule, RoutingComponents } from './service/routing';
import { MatButtonModule } from '@angular/material/button';
import { DemoMaterialModule } from './material-module';



@NgModule({
  declarations: [
    AppComponent,
    SideNavComponent,
    HomeComponent,
    WineryComponent,
    RoutingComponents,
  ],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    MatMenuModule,
    MatNativeDateModule,
    FormsModule,
    ReactiveFormsModule,
    MatSidenavModule,
    MatIconModule,
    MatToolbarModule,
    MatListModule,
    HttpClientModule,
    MatButtonModule,
    DemoMaterialModule,
    RoutingModule,
    CommonModule
  ],
  entryComponents: [SideNavComponent],
  providers: [
    WineService,
    RoutingModule,
    {provide: LocationStrategy, useClass: HashLocationStrategy}
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }

