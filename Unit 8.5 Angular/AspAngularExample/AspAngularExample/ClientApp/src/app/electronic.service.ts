import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class ElectronicService {

  constructor(private http:HttpClient, @Inject('BASE_URL') private baseUrl:string) { }

  getAllElectronics():any{
    return this.http.get(this.baseUrl + "api/Electronic/getAll");
  }

}
