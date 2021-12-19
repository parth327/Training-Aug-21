import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'AngD9';

  studentList: any[] = []
  addStudent(student: any) {
    this.studentList.push(student)
  }
}
