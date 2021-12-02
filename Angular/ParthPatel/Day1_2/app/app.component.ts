import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent{

practice:boolean=false;  
login:boolean=false;
signup:boolean=false;
rectangle:boolean=false;
circle:boolean=false;
click1(){
  if(this.practice==false){
  this.practice=true;
  }
  else{
    this.practice=false;
  }
}
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

}