import { Component} from '@angular/core';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent {

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
  

}

