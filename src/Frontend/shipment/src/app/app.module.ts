import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { RandomQuoteComponent } from './random-quote/random-quote.component';
import { QuotesComponent } from './quotes/quotes.component';
import { ShippersComponent } from './shippers/shippers.component';
import {  HttpClientModule } from '@angular/common/http';

@NgModule({
  declarations: [
    AppComponent,
    RandomQuoteComponent,
    QuotesComponent,
    ShippersComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
