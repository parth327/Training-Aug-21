import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-hello',
  templateUrl: './hello.component.html',
  styleUrls: ['./hello.component.css']
})
export class HelloComponent implements OnInit {
  
  constructor() { }

  ngOnInit(): void {
  }
  call : string = 'Hello World';
  greeting : string = 'Hello';
  name : string = 'Parth';
}
