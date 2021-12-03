import { Component} from '@angular/core';

@Component({
  selector: 'app-practice',
  templateUrl: './practice.component.html',
  styleUrls: ['./practice.component.css']
})
export class PracticeComponent{

  canSave=true;
  isUnchanged=true;
  isSpecial=true;
  
  currentClasses: Record<string, boolean> = {};
setCurrentClasses() {
   this.currentClasses =  {
    saveable: this.canSave,
    modified: !this.isUnchanged,
    special:  this.isSpecial
  };
}  
currentStyles: Record<string,string>={};
setCurrentStyles(){
  this.currentStyles = {
    'font-style':  this.canSave      ? 'italic' : 'normal',
    'font-weight': !this.isUnchanged ? 'bold'   : 'normal',
    'font-size':   this.isSpecial    ? '24px'   : '12px'
  };  
}
people: any[] = [
  {
    "name": "Douglas  Pace",
    "age": 35
  },
  {
    "name": "Mcleod  Mueller",
    "age": 32
  },
  {
    "name": "Day  Meyers",
    "age": 21
  },
  {
    "name": "Aguirre  Ellis",
    "age": 34
  },
  {
    "name": "Cook  Tyson",
    "age": 32
  }
];

}


