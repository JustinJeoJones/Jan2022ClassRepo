import { Component, OnInit } from '@angular/core';
import { LoggerService } from '../logger.service';

@Component({
  selector: 'app-logger',
  templateUrl: './logger.component.html',
  styleUrls: ['./logger.component.css']
})
export class LoggerComponent implements OnInit {

  constructor(private logger: LoggerService) { }

  ngOnInit(): void {
    this.logger.log("Hi!");
    this.logger.warn("This is a warning");
    this.logger.error("Something went wrong");
  }

}
