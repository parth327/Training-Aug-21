import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import {Jsd1Component} from '../jsd1/jsd1.component';
import {Jsd2Component} from '../jsd2/jsd2.component';
import {Jsd3Component} from '../jsd3/jsd3.component';
import {Jsd4Component} from '../jsd4/jsd4.component';
import {Jsd5Component} from '../jsd5/jsd5.component';


const routes: Routes = [
  {path:'js',children:[
    {path:'day1',component:Jsd1Component},
    {path:'day2',component:Jsd2Component},
    {path:'day3',component:Jsd3Component},
    {path:'day4',component:Jsd4Component},
  ]}
];


@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class JsRoutingModule { }
