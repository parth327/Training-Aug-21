import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { AdminServiceService } from '../admin-service.service';

@Component({
  selector: 'app-admin',
  templateUrl: './admin.component.html',
  styleUrls: ['./admin.component.css'],
  providers:[AdminServiceService]
})
export class AdminComponent implements OnInit {

  constructor(private service:AdminServiceService,private routes:Router) { }
  msg;
  ngOnInit(): void {
  }

  check(uname:string,pwd:string)
  {
    var output = this.service.checkusernameandpassword(uname,pwd)
    if(output==true)
    { 
      this.routes.navigate(['/dashboard']);
    }
    else{
      this.msg='invalid';
    }
  }

}
