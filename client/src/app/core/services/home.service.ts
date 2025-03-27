import { inject, Injectable } from '@angular/core';
import { HttpClient } from "@angular/common/http";
import {environment} from '../../../environments/environment';

@Injectable({
  providedIn: 'root'
})
export class HomeService {
  private http = inject(HttpClient);
  private url = `${environment.apiUrl}/home`;
  
  callTestEndpoint(){
    this.http.get(this.url).subscribe();
  }
  
}
