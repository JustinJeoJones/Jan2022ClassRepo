import { Component, OnInit } from '@angular/core';
import { Favorite } from '../favorite';
import { FavoriteService } from '../favorite.service';

@Component({
  selector: 'app-favorites',
  templateUrl: './favorites.component.html',
  styleUrls: ['./favorites.component.css']
})
export class FavoritesComponent implements OnInit {

  favorites: Favorite[] = [];
  constructor(private favoriteService: FavoriteService) { }


  ngOnInit(): void {
    this.favoriteService.getFavorites().subscribe((response: Favorite[]) =>{
     console.log(response);
      this.favorites = response;
    });
  }

}
