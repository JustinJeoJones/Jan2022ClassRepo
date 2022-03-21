import { Injectable } from '@angular/core';
import { Hero } from './hero';

@Injectable({
  providedIn: 'root'
})
export class HeroService {
  heros:Hero[] = [
    {
      Name:"Bruce Wayne",
      HeroName: "Batman",
      Popularity: 10
    },
    {
      Name:"Bruce Banner",
      HeroName:"Hulk",
      Popularity: 8
    },
    {
      Name: "Peter Parker",
      HeroName:"Spider-man",
      Popularity: 9
    },
    {
      Name: "Otto Octavius",
      HeroName: "Superior Spider-man",
      Popularity: 5
    },
    {
      Name:"Keven Moskowitz",
      HeroName: "The Deep",
      Popularity: 1
    }
  ];
  constructor() { }

  getAllHeros():Hero[] {
    return this.heros;
  }
  getByName(name:string):Hero | undefined{
    return this.heros.find(h => h.Name == name);
  }
  getByHeroName(heroName:string): Hero | undefined {
    return this.heros.find(h => h.HeroName == heroName);
  }
}
