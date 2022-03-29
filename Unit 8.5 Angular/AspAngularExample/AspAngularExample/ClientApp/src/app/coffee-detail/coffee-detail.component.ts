import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Coffee } from '../coffee';
import { CoffeeService } from '../coffee.service';

@Component({
  selector: 'app-coffee-detail',
  templateUrl: './coffee-detail.component.html',
  styleUrls: ['./coffee-detail.component.css']
})
export class CoffeeDetailComponent implements OnInit {

  result:Coffee = {} as Coffee;
  constructor(private route:ActivatedRoute, private coffeeService:CoffeeService) { }

  ngOnInit(): void {
    let id:number = Number(this.route.snapshot.paramMap.get("id"));
    this.coffeeService.getById(id).subscribe((response:Coffee) => {
      this.result = response;
    });
  }

}
