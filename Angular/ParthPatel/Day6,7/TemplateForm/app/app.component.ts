import { Component } from '@angular/core';
import { FormGroup,FormControl,Validators } from '@angular/forms';
// import { QuestionControlService } from './qusetion-control.service';
// import { QuestionBase } from './question-base';
// import { Observable } from 'rxjs';

@Component({

  selector: 'app-root',
  templateUrl:'./app.component.html',
  styleUrls:['./app.component.css']
  // template: `
  // <div>
  //   <h2>Job Application for Heroes</h2>
  //   <app-dynamic-form [questions]="questions$ | async"></app-dynamic-form>
  // </div>
// `,
// providers:  [QuestionControlService],
//   templateUrl: './app.component.html',
//   styleUrls: ['./app.component.css']
})
export class AppComponent {
  // title = 'AngD6';
  // questions$: Observable<QuestionBase<any>[]>;

  // constructor(service: QuestionControlService) {
  //   this.questions$ = service.getQuestions();
  // }
  // title = 'blog';
  // data="hello code "
  // num=100

  // loginForm = new FormGroup({
  //   user:new FormControl('',[Validators.required]),
  //   password:new FormControl(''),
  // })

  // loginUser(){
  //   console.warn(this.loginForm.value)
  // }
}