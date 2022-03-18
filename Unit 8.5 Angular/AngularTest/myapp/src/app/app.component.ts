import { Component } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Car } from './car';
import { Employee } from './employee';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'myapp';
  name:string = "Justin";
  names: string[] = [
    "Fred", "Julie", "Sam", "Olivia", "Adam", "Jennifer", "Shaggy"
  ]
  IsHungry:Boolean = false;
  myCar:Car = {
    make: "Tesla",
    model: "Model 3",
    year: 2020,
    price:60000,
    isUsed: false
  };

  employees:Employee[] = [
    {
      name:"Justin",
      salary: 20,
      isManager: false
    },
    {
      name:"Josh",
      salary: 9000000,
      isManager: true
    },
    {
      name:"Tommy",
      salary: -100,
      isManager: false
    },
  ];

  //Event bindings
  changeTitle(newTitle:string):void{
    this.title = newTitle;
  }

  addName(form:NgForm){
    let newName = form.form.value.inputName;
    this.names.push(newName);
  }
  
}
