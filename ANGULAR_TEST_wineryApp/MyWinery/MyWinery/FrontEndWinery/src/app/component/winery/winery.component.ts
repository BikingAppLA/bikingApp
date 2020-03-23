import { Component, OnInit} from '@angular/core';
import { WineService } from 'src/app/service/wine-service';
import { IWine } from 'src/app/model/wines';
import { find, filter } from 'rxjs/operators';
import { Observable } from 'rxjs';
import { BrowserModule } from '@angular/platform-browser';
import { Route } from '@angular/compiler/src/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-winery',
  templateUrl: './winery.component.html',
  styleUrls: ['./winery.component.css']
})
export class WineryComponent implements OnInit {
  
  public wines = [];
  public newWine: any = { Id: Number, Name: String, Type: String, Producer: String, AlcoholContent: Number, Review: Number, Description: String }
  public editView: string;
  public editedWine: IWine;
  
  public wine: IWine = { id: null, name: '', type: '', producer: '', alcoholContent: null, review: null, description: '', quantity: null }
  
  constructor(private _wineService : WineService, private router: Router) {  
    this._wineService.getWines()
    .subscribe(data => this.wines = data);
  this.editView ="main";
  
  }
  

  ngOnInit() {
    
  }
  
  onClickAdd(): void {
    this._wineService
    .postWine(this.newWine)
    .subscribe(data => {location.reload(); }, error => {console.log(error)}
    );
    this.editView = "main";
  }

  onClickDelete(id: Number) {
    this._wineService.deleteWine(id).subscribe( data => { location.reload();}, error => {console.log(error)});
    }

    onClickTableShow(){
     this.editView="addView";
    }    

    onClickReturn(){
      this.editView="main";
    }

    onSelect(selectedWine: IWine) {
      this.editedWine=selectedWine;
      this.editView = "show";
    }

    onClickEdit(wineToPut: IWine) {
      this._wineService.putWine(wineToPut).subscribe( data => wineToPut = data);
      this.editView= "main";
      // location.reload();
    }
}
