import { Component, OnInit } from '@angular/core';
import { DesignutilityService } from '../appServices/designutility.service';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.css']
})
export class DashboardComponent implements OnInit {

  constructor(private _msgService:DesignutilityService) { }
  
  products;
  ngOnInit(): void {
    this.products=this._msgService.product;
  }

  btnDash(){
    this._msgService.messageAlert();
  } 

}
