import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-cssd3',
  template: `
    <p>
    </p>
    <div class="nav">
    <a href="#"> Home</a> 
    <a href="#"> About Us</a> 
    <a href="#"> Contact</a> 
    <a href="#"> Projects</a> 
    <a href="#"> News</a> 
 </div>  
  `,
  styles: [`
  .nav {
    background-color: #333;
    overflow: hidden;
} 
.nav a {
    float: left;
    display: block;
    color: #f2f2f2;
    text-align: center;
    padding: 14px 16px;
    text-decoration: none;
    font-size: 17px;
}
.nav a:hover {
    background-color: #ddd;
    color: black;
}
.nav a.active {
    background-color: #04AA6D;
    color: white;
}
.nav .icon {
    display: none;
}
@media screen and (max-width: 600px) {
.nav a:not(:first-child) {
    display: none;
    }
.nav a.icon {
    float: right;
    display: block;
    }
}
@media screen and (max-width: 600px) {
.nav.responsive {
    position: relative;
    }
.nav.responsive a.icon {
    position: absolute;
    right: 0;
    top: 0;
}
.nav.responsive a {
    float: none;
    display: block;
    text-align: left;
        }
}

  `
  ]
})
export class Cssd3Component implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }

}
