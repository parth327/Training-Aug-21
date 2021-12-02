import { Directive,ElementRef,HostListener,Input } from '@angular/core';

@Directive({
  selector: '[appHighlight]'
})
export class HighlightDirective {
  constructor(private el : ElementRef) { 
    }  
@HostListener('mouseenter')
onMouseEnter(){
    this.hightlight(this.highlightColor ||this.defaultColor || 'red');
  }
@HostListener('mouseleave')
onMouseLeave(){
  this.hightlight('');
}
private hightlight(color:string){
  this.el.nativeElement.style.backgroundColor=color;
}
@Input() appHighlight = '';
@Input() defaultColor='';
@Input() highlightColor='';
}

