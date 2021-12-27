import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import {Htmld1Component} from '../htmld1/htmld1.component';


const routes: Routes = [
    {path:'html',children:[
    {path:'day1',component:Htmld1Component}
  ]}
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class HtmlModuleRoutingModule { }
