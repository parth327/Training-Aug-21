import { RouterModule,Router } from '@angular/router';
import { Component, OnInit } from '@angular/core';
import { MyserviceService } from '../../app/appServices/myservice.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css'],
  providers:[MyserviceService]
})
export class LoginComponent implements OnInit {

  constructor(private service:MyserviceService,private routes:Router) { }
  msg;
  ngOnInit(): void {
  }
  check(uname:string,p:string)
  {
    var output = this.service.checkusernameandpassword(uname,p)
    if(output==true)
    {
      this.routes.navigate(['/dashboard']);
    }
    else{
      this.msg='invalid';
    }
  }

}
