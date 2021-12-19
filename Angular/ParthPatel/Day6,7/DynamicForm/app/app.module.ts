import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { ReactiveFormsModule } from '@angular/forms';
import { AppComponent } from './app.component';
import { DynamicformComponent } from './dynamicform/dynamicform.component';
import { DynamicformquestionComponent } from './dynamicformquestion/dynamicformquestion.component';
import { QuestionControlService } from './question-control.service';

@NgModule({
  declarations: [
    AppComponent,
    DynamicformComponent,
    DynamicformquestionComponent
  ],
  imports: [
    BrowserModule,
    ReactiveFormsModule
  ],
  providers: [QuestionControlService],
  bootstrap: [AppComponent]
})
export class AppModule { }
