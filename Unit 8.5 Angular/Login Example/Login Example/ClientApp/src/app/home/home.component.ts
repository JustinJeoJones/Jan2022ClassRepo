import { Component } from '@angular/core';
import { NgForm } from '@angular/forms';
import { FavoriteService } from '../favorite.service';
import { Favorite } from '../favorite';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {
  constructor(private favoriteService:FavoriteService){}
  ngOnInit(){

  }
  AddFav(form: NgForm){
    console.log(form.form.value.myText);
    
    this.favoriteService.addFavorite(form.form.value.myText).subscribe((response:any) => {
      console.log(response)
    });
  }
}
