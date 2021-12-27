import { Injectable } from '@angular/core';


@Injectable({
  providedIn: 'root'
})
export class DesignutilityService {

  constructor() { }

  messageAlert(){
    alert("Thanks for Subscribe.");
  }

  product=[
    {name:"Laptop",id:"823482"},
    {name:"Mobile",id:"823434"},
    {name:"Washing Machine",id:"823432"},
  ];

}
