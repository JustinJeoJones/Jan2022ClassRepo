import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Todo } from '../todo';

@Component({
  selector: 'app-todo',
  templateUrl: './todo.component.html',
  styleUrls: ['./todo.component.css']
})
export class TodoComponent implements OnInit {
  filter:string = "";
  
  tasks:Todo[] =[
    {
      task:"Wake up",
      completed: true
    },
    {
      task:"Brush teeth",
      completed:true
    },
    {
      task:"Eat breakfast",
      completed:false
    }
  ];
  constructor() { }

  ngOnInit(): void {
  }

  completeTask(input:Todo):void {
    let index = this.tasks.findIndex(t => t.task == input.task && t.completed == input.completed);
    this.tasks[index].completed = true;
  }

  addTodo(form:NgForm):void{
    let newTodo:Todo = {
      task: form.form.value.Task,
      completed: false
    };

    this.tasks.push(newTodo);
  }

  congratulationsCheck():boolean{
    let result:boolean = true; 
    this.tasks.forEach((t:Todo) =>{
      if(t.completed == false){
        result = false;
      }
    });
    //passes all checks
    return result;
  }

  removeTask(input:Todo):void{
    let index = this.tasks.findIndex(t => t.completed == input.completed && t.task == input.task);
    this.tasks.splice(index,1);
  }

  filterTasks():Todo[] {
    return this.tasks.filter(t => t.task.includes(this.filter));
  }

  updateFilter(input:string):void{
    this.filter = input;
  }

  editTodo(form:NgForm, input:Todo):void{
    let index = this.tasks.findIndex(t => t.completed == input.completed && t.task == input.task);
    this.tasks[index].task = form.form.value.newTask;
  }
}
