import { Component } from '@angular/core';
import { NgForm } from '@angular/forms';
import { MenuItem } from './menu-item';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'menu';
  Menu:MenuItem[] = [
    {
      name: "Chicken Fingers",
      category: "Dinner",
      price: 11.99
    },
    {
      name: "Wings",
      category:"Sides",
      price: 8.99
    },
    {
      name:"Ceasar Salad",
      category: "Salads",
      price: 5.99
    },
    {
      name: "Pizza",
      category: "Dinner",
      price: 11.99
    },
    {
      name: "Breadsticks",
      category: "Sides",
      price: 4.99
    },
    {
      name: "Cinnamon Roll",
      category: "Dessert",
      price: 8.99
    }
  ];

  // getByCategory(category: string):MenuItem[]{
  //   let result: MenuItem[] = [];
  //   this.Menu.forEach((Item:MenuItem) => {
  //     if(Item.category.toLowerCase() == category.toLowerCase()){
  //       result.push(Item);
  //     }
  //   });
  //   return result;
  // }
  

  getByCategory(category: string):MenuItem[]{
    return this.Menu.filter(item => item.category.toLowerCase() == category.toLowerCase());
  }

  addItem(form:NgForm){
    let NewName:string = form.form.value.name;
    let NewCategory:string = form.form.value.category;
    let NewPrice:number = form.form.value.price;
    let NewItem:MenuItem = {
      name: NewName,
      category: NewCategory,
      price: NewPrice
    };
    this.Menu.push(NewItem);
  }

}
