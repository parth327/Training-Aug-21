import { NgModule,CUSTOM_ELEMENTS_SCHEMA } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { ReactiveFormsModule } from '@angular/forms';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { EmployeeFormTdComponent } from './employee-form-td/employee-form-td.component';
//import { DynamicformComponent } from './dynamicform/dynamicform.component';
//import { DynamicformquestionComponent } from './dynamicformquestion/dynamicformquestion.component';


@NgModule({
  declarations: [
    AppComponent,
    EmployeeFormTdComponent
  //  DynamicformComponent,
  //DynamicformquestionComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    ReactiveFormsModule
  ],
  providers: [],
  bootstrap: [AppComponent,EmployeeFormTdComponent]
})
export class AppModule {
  constructor(){
    
  }
 }
