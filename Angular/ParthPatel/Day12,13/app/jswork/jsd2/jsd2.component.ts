import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-jsd2',
  templateUrl: './jsd2.component.html',
  styleUrls: ['./jsd2.component.css']
})
export class Jsd2Component implements OnInit 
{

   constructor() { }

   ngOnInit(): void {}


  // var str = prompt("Enter date in form mm-dd-yyyy");
  // var month, day, year;
  // var validDate = false;

  // if (/\d/.test(str)) 
  // {
  //   validDate = true;
  // }
  // else 
  // {
  //   validDate = false;
  // }
  // Month validition
  // if (parseInt(str.slice(0, 2)) <= 12 && parseInt(str.slice(0, 2)) >= 1) 
  // {
  //   month = parseInt(str.slice(0, 2));
  // }
  // else 
  // {
  //   alert("Invalid Month");
  //   validDate = false;
  // }
  // Day Validation
  // if (parseInt(str.slice(3, 5)) <= 31 && parseInt(str.slice(3, 5)) >= 1) 
  // {
  //   day = parseInt(str.slice(3, 5));
  // }
  // else 
  // {
  //   alert("Invalid Day");
  //   validDate = false;
  // }
  //Month with 30 days and month with 31 days validation
  // year = str.substr(6, 4);
  // if (day == 31) 
  // {
  //   if (month == 1 || month == 3 || month == 5 || month == 7 || month == 10 || month == 12) 
  //   {
  //     validDate = true;
  //   }
  //   else if (month == 4 || month == 6 || month == 9 || month == 11) 
  //   {
  //     validDate = true;
  //   }
  //   else 
  //   {
  //     validDate = false;
  //   }
  // }
  // Leap Year
  // var isleapyear = ((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0);
  // if (isleapyear && month == 2 && day > 29) 
  // {
  //   validDate = false;
  // }
  // if (!(isleapyear) && month == 2 && day > 28) 
  // {
  //   validDate = false;
  // }
  //See Output
  // if (validDate) 
  // {
  //   alert("Click OK to see your date") ;
  //   var date = new Date(year, month, day);
  //   document.getElementById("date").innerHTML = date.toDateString();
  // }



}
