import { Component} from '@angular/core';

@Component({
  selector: 'app-circle',
  templateUrl: './circle.component.html',
  styleUrls: ['./circle.component.css']
})
export class CircleComponent{
   r : number ;
   area(){
     return 3.14*this.r*this.r;
   }
}
