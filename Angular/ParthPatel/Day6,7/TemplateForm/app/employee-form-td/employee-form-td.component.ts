import { Component, OnInit } from '@angular/core';
import { Employee } from '../Employee';

@Component({
  selector: 'app-employee-form-td',
  templateUrl: './employee-form-td.component.html',
  styleUrls: ['./employee-form-td.component.css']
})
export class EmployeeFormTdComponent implements OnInit {

  constructor() { }

  skills = ['HTML', 'CSS', 'JS']

  model = new Employee(11, "John", this.skills[0]);


  addEmployee() {
    this.model = new Employee(0, '', '');
  }

  submitted = false;

  onSubmit() { this.submitted = true; }


  ngOnInit(): void {
  }

}
