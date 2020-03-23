import { Injectable } from "@angular/core";
import { HttpClient, HttpErrorResponse } from "@angular/common/http";
import { IWine }      from "../model/wines";
import { Observable, throwError } from 'rxjs';
import { catchError } from 'rxjs/operators';
import { Config } from 'protractor';

@Injectable()
export class WineService {

  private _url : string = "http://localhost:61319/api/";
  static type: string;
  static producer: string;
  static alcoholContent: number;
  static review: number;
  static description: string;
  

constructor (private http: HttpClient) {  }

getWines(): Observable<IWine[]>{
    
    return this.http.get<IWine[]>(this._url + "lista");
}

getUser(): Observable<string>{
    return this.http.get<string>(this._url + "user")
}

getWineById(id: Number): Observable<IWine> {
  return this.http.get<IWine>(this._url + "wineById" + "/" + id)
}

postWine(newWine: IWine): Observable<IWine>{
    return this.http.post<IWine>(this._url + "postWine", newWine)
}
  

deleteWine(id: any): Observable<void>{
    return this.http.post<any>(this._url + "deleteWine", id)
}

putWine(wine: IWine): Observable<IWine>{
    return this.http.post<IWine>(this._url + "putWine", wine)
}




  
//   getConfig() {
//     return this.http.get<Config>(this._url)
//       .pipe(
//         catchError(this.handleError)
//       );
//   }
}