import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
    providedIn: 'root'
})
export class QuoteService {

    constructor(private httpClient: HttpClient) { }

    public GetRandomQuote() {
       return this.httpClient.get
        ('https://localhost:44326/api/' + 'Quote/Random');
    }


    public GetQuotes() {
        return this.httpClient.get
        ('https://localhost:44326/api/Quote?authorName=Albert Einstein&page=1&limit=30');
    }
}
