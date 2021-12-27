import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-d1and2',
  template: `
      <p>
        d1and2 works!
      </p>
    <div class="container-fluid">
      <div class="container-fluid">
        <div class="topnav">
          <a (click)="click2()">LOGIN</a>
          <a (click)="click3()">SIGNUP</a>
          <a (click)="click4()">RECTANLE</a>
          <a (click)="click5()">CIRCLE</a>
        </div>
      </div>
      <div class="row content mt-5">
        <div class="col-sm-3 sidenav">
          <div class="container">
            <img src="../../assets/Dummy1.png" alt="dummy1" width="280" height="600">
          </div>
        </div>
        <div class="col-sm-9 mt-5">
        <div *ngIf="login">
          <div class="container">
            <form class="border border-dark bg-light needs-validation p-3 " novalidate>
              <label for="uname" class="form-label">Username</label>
              <input name="uname"[(ngModel)]="uname" type="text" class ="form-control" id="uname" placeholder="Enter Username" required>
              <label for="password" class="form-label">Password</label>
              <input name="inputPassword" [(ngModel)]="password" type="password" class="form-control"placeholder="Enter Password" id="password" required>
              <button (click)="signin()" type="submit" class="btn btn-outline-primary mt-3">SIGN IN</button><br>
              <label name="result"  class="form-label mt-2">{{result}}</label>    
            </form>
          </div>
        </div>
        <div *ngIf="signup">
          <div class="container">    
            <form class="border border-dark 10px solid black p-3 bg-light">
              <label for="name" class="form-label">Name</label>
              <input name="name"[(ngModel)]="name" type="text" class ="form-control" id="name" placeholder="Enter Your name">
              <label for="address" class="form-label">Address</label>
              <input name="address" [(ngModel)]="address" type="text" class="form-control" placeholder="Enter your Address" id="address">
              <label for="panNo" class="form-label">PAN No.</label>
              <input name="panNo" [(ngModel)]="panNo" type="text" class="form-control" placeholder="Enter your PAN No." id="panNo">
              <button (click)="register()" type="submit" class="btn btn-outline-success mt-3">SIGN UP</button>
              <p>{{resultSignup}}</p>
            </form>
          </div>
        </div>
        <div *ngIf="rectangle">
          <div class="container border border-dark bg-light p-3">
            <input class="form-control" type="number" name="n1" [(ngModel)]="n1" placeholder="Enter width" >
            <input class="form-control mt-3" type="number" name="n2" [(ngModel)]="n2" placeholder="Enter length">
            <h5 class="mt-2">Rectangle area is :{{n3()}} </h5>
          </div>
        </div>
        <div *ngIf="circle">
          <div class="container bg-light border border-dark p-3">
            <input class="form-control" type="number" [(ngModel)]="r" placeholder="Enter Radius of Circle " >
            <br>
            <h5>Area of Circle is : {{area()}}</h5>
            </div>
          </div>
        </div>
      </div>
    </div>
  `,
  styles: [`
    body {
      margin: 0;
      font-family: Arial, Helvetica, sans-serif;
    }
    
    .topnav {
      overflow: hidden;
      background-color: #333;
      top:0;
    }
    
    .topnav a {
      float: left;
      color: #f2f2f2;
      text-align: center;
      padding: 14px 16px;
      text-decoration: none;
      font-size: 17px;
    }
    
    .topnav a:hover {
      background-color: #ddd;
      color: black;
    }
    
    .topnav a.active {
      background-color: #04AA6D;
      color: white;
    }
    `
  ]
})
export class D1and2Component implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }


login:boolean=false;
signup:boolean=false;
rectangle:boolean=false;
circle:boolean=false;
click2(){
  if(this.login==false){
  this.login=true;
  }
  else{
    this.login=false;
  }
}
click3(){
  if(this.signup==false){
  this.signup=true;
  }
  else{
    this.signup=false;
  }
}
click4(){
  if(this.rectangle==false){
  this.rectangle=true;
  }
  else{
    this.rectangle=false;
  }
}
click5(){
  if(this.circle==false){
  this.circle=true;
  }
  else{
    this.circle=false;
  }
}


//login
public uname : string ;
  public password :string ;
  public result : string ;
  signin()
  {
    if(this.uname=="admin" && this.password=="admin")
    {
      this.result="Valid User";
    }
    else
    {
      this.result="Invalid User";
    }  
  }
  //signup
  public name : string ;
  public address : string;
  public panNo : string;
  public resultSignup : string;
  register()
  {
    this.resultSignup="You Entered Data :- " + " \n " +"("+ " Name : " + this.name +","+ " Address : " + this.address + ","+" PAN No. : " + this.panNo+")";
  }
  //rectangle
  public n1:number;
  public n2:number;
  
   n3(){
     return this.n1*this.n2;
   }
   //circle
   r : number ;
   area(){
     return 3.14*this.r*this.r;
   }
}




// <nav class="navbar bg-primary">
// <ul class="navbar-nav">
//   <li class="nav-item">
//   <a (click)="click2()" class="text-light" href="#">LOGIN</a>
//   </li>
//   <li class="nav-item">
//     <a (click)="click3()" class="text-light" href="#">SIGNUP</a>
//   </li>
//   <li class="nav-item">
//     <a (click)="click4()" class="text-light" href="#">RECTANGLE</a> 
//   </li>
//   <li class="nav-item">
//     <a (click)="click5()" class="text-light" href="#">CIRCLE</a> 
//   </li>
// </ul>
// </nav>
