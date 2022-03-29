import { Component, OnInit } from '@angular/core';
import { Electronic } from '../electronic';
import { ElectronicService } from '../electronic.service';

@Component({
  selector: 'app-electronic',
  templateUrl: './electronic.component.html',
  styleUrls: ['./electronic.component.css']
})
export class ElectronicComponent implements OnInit {

  result:Electronic[] = [];
  constructor(private electronicService:ElectronicService) { }

  ngOnInit(): void {
    this.electronicService.getAllElectronics().subscribe((response:Electronic[]) => {
      this.result = response;
      console.log(response);
    });
  }

}
