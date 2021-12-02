import { Component} from '@angular/core';

@Component({
  selector: 'app-rectangle',
  templateUrl: './rectangle.component.html',
  styleUrls: ['./rectangle.component.css']
})
export class RectangleComponent{

  public n1:number;
  public n2:number;
  
   n3(){
     return this.n1*this.n2;
   }
  
}
