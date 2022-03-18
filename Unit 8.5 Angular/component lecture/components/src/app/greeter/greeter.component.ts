import { Component, Input, OnInit, Output, EventEmitter } from '@angular/core';

@Component({
  selector: 'app-greeter',
  templateUrl: './greeter.component.html',
  styleUrls: ['./greeter.component.css']
})
export class GreeterComponent implements OnInit {

  @Input() name = 'Fred';
  @Output() select = new EventEmitter<string>();
  constructor() { }

  ngOnInit(): void {
  }

  selectName():void{
    this.select.emit(this.name);
  }

}
