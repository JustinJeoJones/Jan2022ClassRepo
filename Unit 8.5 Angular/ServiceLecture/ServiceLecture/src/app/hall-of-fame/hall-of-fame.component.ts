import { Component, OnInit } from '@angular/core';
import { HallOfFame } from '../hall-of-fame';
import { ScienceApiService } from '../science-api.service';

@Component({
  selector: 'app-hall-of-fame',
  templateUrl: './hall-of-fame.component.html',
  styleUrls: ['./hall-of-fame.component.css']
})
export class HallOfFameComponent implements OnInit {

  //{} as Interface creates empty object
  result:HallOfFame = {} as HallOfFame;
  constructor(private scienceService: ScienceApiService) { }

  ngOnInit(): void {

    this.scienceService.getHallOfFame().subscribe((response:HallOfFame) => {
      this.result = response;
    },(error:any) => {
      console.log(error);
    });

  }

}
