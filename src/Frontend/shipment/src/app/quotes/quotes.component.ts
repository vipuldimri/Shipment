import { Component } from '@angular/core';
import { QuoteService } from '../services/quote.service';

@Component({
  selector: 'app-quotes',
  templateUrl: './quotes.component.html',
  styleUrls: ['./quotes.component.css']
})
export class QuotesComponent {

  public quotes: any[] = [];
  public shortQuotes: any[] = [];
  public mediumQotes: any[] = [];
  public largeQuotes: any[] = [];

  constructor(private _quoteService: QuoteService) {
    this._Fetch30Quotes();
  }

  private _Fetch30Quotes(): void{
    this._quoteService.GetQuotes()
    .subscribe(
      (result: any) =>{
          this.quotes = result.results;

          this.quotes.forEach(quote => {
               if(quote.length < 10){
                   this.shortQuotes.push(quote);
               }else if(quote.length <= 20){
                this.mediumQotes.push(quote);
               }else{
                this.largeQuotes.push(quote);
               }
          });
      },
      ()=>{
          alert('Unable to fetch quotes list!!');
      }
    );
  }

}
