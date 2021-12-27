import { Component, OnInit ,Input} from '@angular/core';

@Component({
  selector: 'app-jsd1',
  templateUrl: './jsd1.component.html',
  styleUrls: ['./jsd1.component.css']
})
export class Jsd1Component implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }
  public num1:number;
  public num2:number;
  public num3:number;
  add(){
    this.num3=this.num1+this.num2;
  }
  sub(){
    this.num3=this.num1-this.num2;
  }
  mul(){
    this.num3=this.num1*this.num2;
  }



}
