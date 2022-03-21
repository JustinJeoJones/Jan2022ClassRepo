import { Component, OnInit } from '@angular/core';
import { Hero } from '../hero';
import { HeroService } from '../hero.service';

@Component({
  selector: 'app-hero',
  templateUrl: './hero.component.html',
  styleUrls: ['./hero.component.css']
})
export class HeroComponent implements OnInit {

  heros:Hero[] = [];

  constructor(private heroService: HeroService) { }

  ngOnInit(): void {
    this.heros = this.heroService.getAllHeros();
  }

}
