import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { Htmld1Component } from './htmlwork/htmld1/htmld1.component';
import { PageNotFoundComponent } from './page-not-found/page-not-found.component';
import { CssComponent } from './csswork/cssd1/css.component';
import { Cssd2Component } from './csswork/cssd2/cssd2.component';
import { Cssd3Component } from './csswork/cssd3/cssd3.component';
import { Cssd4and5Component } from './csswork/cssd4/cssd4and5.component';
import { Cssd5Component } from './csswork/cssd5/cssd5.component';
import { Jsd1Component } from './jswork/jsd1/jsd1.component';
import { Jsd2Component } from './jswork/jsd2/jsd2.component';
import { Jsd3Component } from './jswork/jsd3/jsd3.component';
import { Jsd4Component } from './jswork/jsd4/jsd4.component';
import { Jsd5Component } from './jswork/jsd5/jsd5.component';
import { DashboardComponent } from './dashboard/dashboard.component';
import { LoginComponent } from './login/login.component';
import { AdminComponent } from './admin/admin.component';
import { CardComponent } from './card/card.component';
import { HtmlworkComponent } from './htmlwork/htmlwork.component';
import { CssworkComponent } from './csswork/csswork.component';
import { JsworkComponent } from './jswork/jswork.component';
import {HtmlModuleModule} from './htmlwork/html-module/html-module.module';
import { CssModule } from './csswork/css/css.module';
import { JsModule } from './jswork/js/js.module';

@NgModule({
  declarations: [
    Htmld1Component,
    CssComponent,
    Cssd2Component,
    Cssd3Component,
    Cssd4and5Component,
    Cssd5Component,
    Jsd1Component,
    Jsd2Component,
    Jsd3Component,
    Jsd4Component,
    Jsd5Component,
    DashboardComponent,
    LoginComponent,
    AdminComponent,
    CardComponent,                                
    PageNotFoundComponent,
    AppComponent,
    PageNotFoundComponent,
    HtmlworkComponent,
    CssworkComponent,
    JsworkComponent,
    ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    HtmlModuleModule,
    CssModule,
    JsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }





