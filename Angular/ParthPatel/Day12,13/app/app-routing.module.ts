import { NgModule } from '@angular/core';
import { RouterModule, Routes,CanActivate } from '@angular/router';
import { PageNotFoundComponent } from './page-not-found/page-not-found.component';
import { CssComponent } from './csswork/cssd1/css.component';
import { Cssd2Component } from './csswork/cssd2/cssd2.component';
import { Cssd3Component } from './csswork/cssd3/cssd3.component';
import { Cssd4and5Component } from './csswork/cssd4/cssd4and5.component';
import { Cssd5Component } from './csswork/cssd5/cssd5.component';
import { Htmld1Component } from './htmlwork/htmld1/htmld1.component';
import { Jsd1Component } from './jswork/jsd1/jsd1.component';
import { Jsd2Component } from './jswork/jsd2/jsd2.component';
import { Jsd3Component } from './jswork/jsd3/jsd3.component';
import { Jsd4Component } from './jswork/jsd4/jsd4.component';
import { Jsd5Component } from './jswork/jsd5/jsd5.component';
import { HtmlworkComponent } from './htmlwork/htmlwork.component';
import { CssworkComponent } from './csswork/csswork.component';
import { JsworkComponent } from './jswork/jswork.component';

export const routes: Routes = [
  {path:'html',component:HtmlworkComponent,
    children:[
      {path:'day1',component:Htmld1Component},
    ]
  },
  {path:'css',component:CssworkComponent,
    children:[
        {path:'day1',component:CssComponent},
        {path:'day2',component:Cssd2Component},
        {path:'day3',component:Cssd3Component},
        {path:'day4',component:Cssd4and5Component},
        {path:'day5',component:Cssd5Component}
    ]
  },
  {path:"js",component:JsworkComponent,
    children:[
      {path:'day1',component:Jsd1Component},
      {path:'day2',component:Jsd2Component},
      {path:'day3',component:Jsd3Component},
      {path:'day4',component:Jsd4Component},
      {path:'day5',component:Jsd5Component}    
    ]
  },
  {path:"**",component:PageNotFoundComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
