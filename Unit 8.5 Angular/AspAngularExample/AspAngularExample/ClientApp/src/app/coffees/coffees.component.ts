import { Component, OnInit } from '@angular/core';
import { Coffee } from '../coffee';
import { CoffeeService } from '../coffee.service';

@Component({
  selector: 'app-coffees',
  templateUrl: './coffees.component.html',
  styleUrls: ['./coffees.component.css']
})
export class CoffeesComponent implements OnInit {

  coffees:Coffee[] = [];
  constructor(private coffeeService:CoffeeService) { }

  ngOnInit(): void {
    this.coffeeService.getAll().subscribe((response:Coffee[]) => {
      this.coffees = response;
      console.log(response);
    });
  }

}
