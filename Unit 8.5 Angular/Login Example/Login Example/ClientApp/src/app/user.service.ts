import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class UserService {

  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) { }

  login(username:string, password:string):any{
    return this.http.get(this.baseUrl+`api/User/login?username=${username}&password=${password}`);
  }

  addUser(username:string, password:string):any{
    return this.http.post(this.baseUrl+`api/User/login?username=${username}&password=${password}`, {});
  }
}
