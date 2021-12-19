import { Component,Output,EventEmitter} from '@angular/core';
import { FormGroup,FormControl } from '@angular/forms';
import { FormBuilder } from '@angular/forms';
import { FormArray } from '@angular/forms';
import { Validators } from '@angular/forms';





@Component({
  selector: 'app-student',
  templateUrl: './student.component.html',
  styleUrls: ['./student.component.css']
})
export class StudentComponent {

  @Output() newStudentEvent = new EventEmitter<string>();
  addNewStudent(value: string){
    this.newStudentEvent.emit(value);
  }  
 

}





