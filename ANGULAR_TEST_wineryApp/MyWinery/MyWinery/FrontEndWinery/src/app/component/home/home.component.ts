import { Component, OnInit } from '@angular/core';
import { WineService } from 'src/app/service/wine-service'


@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  //attualmente non c'è autenticazione windows, => user... nada
  public user: string;
  constructor(private _wineservice: WineService) { }
  ngOnInit() {
    this._wineservice.getUser()
        .subscribe(data => this.user = data);
  }

}
