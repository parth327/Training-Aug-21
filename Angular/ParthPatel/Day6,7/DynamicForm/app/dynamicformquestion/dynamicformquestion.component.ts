import { Component, OnInit,Input } from '@angular/core';
import { FormGroup } from '@angular/forms';

import { QuestionBase } from '../question-base';


@Component({
  selector: 'app-dynamicformquestion',
  templateUrl: './dynamicformquestion.component.html',
  styleUrls: ['./dynamicformquestion.component.css']
})
export class DynamicformquestionComponent implements OnInit {

  @Input() question!: QuestionBase<string>;
  @Input() form!: FormGroup;

  get isValid() {
    return this.form.controls[this.question.key].valid;
  }
  get isTouched() {
    return this.form.controls[this.question.key].touched;
  }

  constructor() { }

  ngOnInit(): void {
  }

}
