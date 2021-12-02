import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NavComponent } from './nav/nav.component';
import { HelloComponent } from './hello/hello.component';
import { CalcComponent } from './calc/calc.component';
import { RectangleComponent } from './rectangle/rectangle.component';
import { LoginComponent } from './login/login.component';
import { CircleComponent } from './circle/circle.component';
import { LeftbarComponent } from './leftbar/leftbar.component';
import { SignupComponent } from './signup/signup.component';
import { HighlightDirective } from './highlight.directive';
import { Day3PracComponent } from './day3-prac/day3-prac.component';

@NgModule({
  declarations: [
    AppComponent,
    NavComponent,
    HelloComponent,
    CalcComponent,
    RectangleComponent,
    LoginComponent,
    CircleComponent,
    LeftbarComponent,
    SignupComponent,
    HighlightDirective,
    Day3PracComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent,HelloComponent,CalcComponent,RectangleComponent,LoginComponent,CircleComponent,
  LeftbarComponent,SignupComponent]
})
export class AppModule { }
