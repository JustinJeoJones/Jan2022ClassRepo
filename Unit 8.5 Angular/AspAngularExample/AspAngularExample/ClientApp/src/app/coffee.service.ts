import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class CoffeeService {

  constructor(private http:HttpClient, @Inject('BASE_URL') private baseURL: string) { }

  getAll():any {
    return this.http.get(`${this.baseURL}api/Coffee/GetAll`);
  }

  getById(id:number):any {
    return this.http.get(`${this.baseURL}api/Coffee/GetById?id=${id}`)
  }

}
