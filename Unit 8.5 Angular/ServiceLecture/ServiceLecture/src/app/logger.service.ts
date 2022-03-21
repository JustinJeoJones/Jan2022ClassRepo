import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class LoggerService {

  log(msg: any):void {
    console.log(`[${new Date()}] ${msg}`);
  }

  error(msg: any):void {
    console.error(`[${new Date()}] ${msg}`);
  }

  warn(msg: any):void {
    console.warn(`[${new Date()}] ${msg}`);
  }
  
  constructor() { }
}
