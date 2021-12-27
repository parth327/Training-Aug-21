import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-cssd2',
  template: `
  <p></p>
    <div class="container">
    <header>
      <div class="logo">LOGO</div>        
    </header>
    <div class="leftbar">Leftbar</div>
    <div class="sidebar">Sidebar</div>
    <footer>Footer</footer>
    </div>
  `,
  styles: [
`
header {
  background-color: red;
  width: 900px;
  height: 50px;
  font-size:30px;
}
header .logo {
      display: inline-block;
      padding: 15px 50px;
}
header nav {
      float: right;
      text-align: right;
      padding: 15px 100px;
}
nav a {
  padding: 25px 50px;
  text-decoration: none;
  color: lavender;
}
.leftbar {
  background-color: yellow;
  height: 300px;
  width: 150px;
  float: left;
  text-align: center;
  font-size:30px;
}
.sidebar {
  background-color: brown;
  height: 300px;
  width: 900px;
  text-align: center;
  font-size:30px;
}
footer {
  background-color: grey;
  width:900px ;
  height:80px ;
  text-align: center;
  font-size:30px;
}
`
  ]
})
export class Cssd2Component implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }

}
