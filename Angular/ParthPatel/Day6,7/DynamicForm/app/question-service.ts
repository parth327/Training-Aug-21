import { Injectable } from '@angular/core';

import { DropdownQuestion } from './question-dropdown';
import { QuestionBase } from './question-base';
import { TextboxQuestion } from './question-textbox';
import { of } from 'rxjs';

@Injectable()
export class QuestionService {

  getQuestions() {

    const questions: QuestionBase<string>[] = [

      new DropdownQuestion({
        key: 'skills',
        label: 'Skills',
        options: [
          { key: 'HTML', value: 'HTML' },
          { key: 'CSS', value: 'CSS' },
          { key: 'JS', value: 'JS' }
        ],
        required: true,
        order: 4
      }),

      new TextboxQuestion({
        key: 'firstName',
        label: 'First Name',
        value: 'John',
        required: true,
        order: 1
      }),

      new TextboxQuestion({
        key: 'lastName',
        label: 'Last Name',
        value: 'Doe',
        required: true,
        order: 2
      }),

      new TextboxQuestion({
        key: 'emailAddress',
        label: 'Email',
        value:"john@gmail.com",
        type: 'email',
        required: true,
        order: 3
      })
    ];

    return of(questions.sort((a, b) => a.order - b.order));
  }
}

