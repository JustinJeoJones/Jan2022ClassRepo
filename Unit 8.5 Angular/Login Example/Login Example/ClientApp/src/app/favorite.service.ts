import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { LoginService } from './login.service';
import { User } from './user';

@Injectable({
  providedIn: 'root'
})
export class FavoriteService {

  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string, private loginService:LoginService) { }

  getFavorites():any{
    let myUser:User = this.loginService.getLogin();
    return this.http.get(this.baseUrl+`api/Favorite/Get?uId=${myUser.id}`);
  }

  addFavorite(text:string):any{
    let myUser:User = this.loginService.getLogin();
    return this.http.post(this.baseUrl+`api/Favorite/Add?uId=${myUser.id}&myText=${text}`, {});
  }
}
