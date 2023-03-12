import { Component } from '@angular/core';
import { QuoteService } from '../services/quote.service';

@Component({
  selector: 'app-random-quote',
  templateUrl: './random-quote.component.html',
  styleUrls: ['./random-quote.component.css']
})
export class RandomQuoteComponent {

  public randomQuote: any;
  constructor(private _quoteService: QuoteService) {

  }


  public FetchRandomQuote(): void{
      this._quoteService.GetRandomQuote()
      .subscribe(
        (quote: any) =>{
          this.randomQuote =  quote;
        },
        (error) =>{
            alert("Something went wrong!");
        }
      );
  }
}
