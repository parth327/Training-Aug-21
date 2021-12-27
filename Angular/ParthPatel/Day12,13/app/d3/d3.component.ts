import { Component, OnInit } from '@angular/core';


interface IStudentModel{
  Id:number;
  Name:string;
  Age:number;
  Average:number;
  Grade:string;
  Active:boolean;
}

@Component({
  selector: 'app-d3',
  template: `
    <p>
      d3 works!
    </p>
    <div class="container">
    <table class="table table-bordered ">
        <thead>
          <tr>
            <th scope="col">ID</th>
            <th scope="col">NAME</th>
            <th scope="col">AGE</th>
            <th scope="col">AVERAGE</th>
            <th scope="col">GRADE</th>
            <th scope="col">ACTIVE</th>
          </tr>
        </thead>
        <tbody>
          <tr [ngStyle]="{'background-color':getGradeColor(Model.Grade)}" [ngSwitch]="Model.Grade" *ngFor="let Model of StudentModel">
            <td>{{Model.Id}}</td>
            <td>{{Model.Name}}</td>
            <td>{{Model.Age}}</td>
            <td>{{Model.Average}}</td>
            <td>{{Model.Grade}}</td>
            <td *ngIf="Model.Active">{{Model.Active}}</td>
          </tr>
        </tbody>
    </table>
</div>



  `,
  styles: [
  ]
})
export class D3Component implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }

  Active:boolean=false;
  StudentModel:IStudentModel[]=[
    {Id:1,Name:"Hardik",Age:20,Average:56,Grade:"D",Active:false},
    {Id:2,Name:"Chintan",Age:22,Average:30,Grade:"F",Active:false},
    {Id:3,Name:"Hemangi",Age:20,Average:86,Grade:"B",Active:true},
    {Id:4,Name:"Rashmi",Age:19,Average:69,Grade:"C",Active:true},
    {Id:5,Name:"Rahul",Age:22,Average:92,Grade:"A",Active:true},
    {Id:6,Name:"Kuldeep",Age:21,Average:43,Grade:"E",Active:false}
  ]


  getGradeColor(Grade){
    switch(Grade){
      case 'A':
        return 'Green';
      case 'B':
        return 'Orange';      
      case 'C':
        return 'Yellow';
      case 'D':
        return 'Blue';
      case 'E':
        return 'Pink';
      case 'F':
        return 'Red';
      default:
        return 'White';
    }
  }
}



