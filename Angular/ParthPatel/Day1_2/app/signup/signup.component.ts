import { Component} from '@angular/core';

@Component({
  selector: 'app-signup',
  templateUrl: './signup.component.html',
  styleUrls: ['./signup.component.css']
})
export class SignupComponent {

  public name : string ;
  public address : string;
  public panNo : string;
  public result : string;
  register()
  {
    this.result="You Entered Data :- " + " \n " +"("+ " Name : " + this.name +","+ " Address : " + this.address + ","+" PAN No. : " + this.panNo+")";
  }

}
