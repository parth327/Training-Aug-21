import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-cssd5',
  template: `

  <div class="layout">
    <header>
       <div class="logo">
       <img src="../../assets/logo.png" alt="logo" style="height:80px;width:200px"/>
       </div>
       <nav>
            <ul>
                <li><a href="#home">HOME</a></li>
                <li><a href="#AbousUs">ABOUT US</a></li>
                <li><a href="#Services">SERVICES</a></li>
            </ul>
       </nav>
    </header>
    <article>
        <h2>Home</h2>
    </article>   
    <footer>
        footer
    </footer>
</div>

  `,
  styles: [`
  * {
  box-sizing:border-box;
  margin:0;
  padding:0;
}
body,html {
  height:100vh;
}
header {
font-size:2em;
height:80px;
background-color:#eee;
display:grid;
grid-template-columns:400px auto;
}
.logo {
grid-column:1/1;
}
nav {
grid-column:2/-1;
}
li a {

float:right;
text-decoration:none;
}
nav ul {
display:grid;     
grid-template-columns:auto auto auto;
}
  nav li {
  list-style:none;
  padding:15px 15px;
  }
li:first-child {
grid-column:1/1;
}
li:nth-child(2) {
  grid-column: 2/2;
}
li:last-child {
grid-column:3/-1;
}
article {
height:47vh;
background-color:yellow;
font-size:2em;
text-align:center;
}
footer {
height:14vh;
background-color:orange;
text-align:center;
font-size:2em;
}
@media (max-width: 900px) {
  header {
      grid-template-columns: 300px auto;
  }
}

@media (max-width: 600px), (max-width: 400px) {
  header {
      grid-template-columns: 1fr 1fr 1fr;
      grid-template-rows: 1fr 1fr;
  }

  .logo {
      grid-row: 1 /1;
      grid-column: 1/3;
  }

  nav {
      grid-column: 1 / 3;
      grid-row: 2/2;
  }
}

@media (max-width: 400px) {
  header {
      height: 200px;
  }

  nav ul {
      display: grid;
      grid-template-columns: auto;
      grid-template-rows: 1fr 1fr 1fr;
  }

  li:first-child {
      grid-column: 1/1;
      grid-row: 1/1;
  }

  li:nth-child(2) {
      grid-column: 1/1;
      grid-row: 2/2;
  }

  li:last-child {
      grid-column: 1/1;
      grid-row: 3/3;
  }
}
  `
  ]
})
export class Cssd5Component implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }

}
