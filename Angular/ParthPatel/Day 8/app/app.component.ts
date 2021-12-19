import { Component } from '@angular/core';
import { FormGroup,FormControl } from '@angular/forms';
import { FormBuilder } from '@angular/forms';
import { FormArray } from '@angular/forms';
import { Validators } from '@angular/forms';




@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  // title = 'AngD8';
  // currentItem='Television';
  students=['student1','student2'];

  addNewStudent(newStudent : string){
    this.students.push(newStudent);
  }

  
}
