import { Component, OnInit } from '@angular/core';
import { DesignutilityService } from '../appServices/designutility.service';

@Component({
  selector: 'app-card',
  template: `
    <p>
      card works!
    </p>
    <div class="card">
      <div class="card-body">
        <h5 class="card-title">Laptop</h5>
        <p class="card-text">Product</p>
        <button (click)="btnClick()" class="btn btn-success">Subscribe</button>
      </div>
    </div>
  `,
  styles: [
  ]
})
export class CardComponent implements OnInit {

  constructor(private _msgService:DesignutilityService) { }

  ngOnInit(): void {
  }

  btnClick(){
    this._msgService.messageAlert();
  }

}
