import { Component} from '@angular/core';

interface IStudentModel{
  Id:number;
  Name:string;
  Age:number;
  Average:number;
  Grade:string;
  Active:boolean;
}

@Component({
  selector: 'app-student-list',
  templateUrl: './student-list.component.html',
  styleUrls: ['./student-list.component.css']
})
export class StudentListComponent{
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
    }
  }
}
