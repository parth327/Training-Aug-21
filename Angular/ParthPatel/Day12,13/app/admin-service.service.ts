import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class AdminServiceService {

  constructor() { }

  checkusernameandpassword(uname:string,pwd:string)
  {
    if(uname=="admin123"&&pwd=="admin12345"){
      localStorage.setItem('username',"admin");
      return true;
    }
    else{
      return false;
    }
  }


}
