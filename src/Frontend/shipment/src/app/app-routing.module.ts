import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AppComponent } from './app.component';
import { QuotesComponent } from './quotes/quotes.component';
import { RandomQuoteComponent } from './random-quote/random-quote.component';
import { ShippersComponent } from './shippers/shippers.component';

const routes: Routes = [
  {
    path: '',
    redirectTo: 'random', pathMatch: 'full',
  },
  { path: 'random', component: RandomQuoteComponent },
  { path: 'quote', component: QuotesComponent },
  { path: 'shipper', component: ShippersComponent, },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
