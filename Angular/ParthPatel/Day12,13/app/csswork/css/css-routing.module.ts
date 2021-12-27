import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import {CssComponent} from '../cssd1/css.component';
import {Cssd2Component} from '../cssd2/cssd2.component';
import {Cssd3Component} from '../cssd3/cssd3.component';
import {Cssd4and5Component} from '../cssd4/cssd4and5.component';
import {Cssd5Component} from '../cssd5/cssd5.component';



const routes: Routes = [
  {path:'css',children:[
    {path:'day1',component:CssComponent},
    {path:'day2',component:Cssd2Component},
    {path:'day3',component:Cssd3Component},
    {path:'day4',component:Cssd4and5Component},
    {path:'day5',component:Cssd5Component}
  ]}
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class CssRoutingModule { }
