using Application.Abstractions;
using Domain.Entities;
using Domain.Parameters;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Infrastructure.External
{
    public class QuoteService : IQuoteService
    {
        private readonly HttpClient _httpClient;
        public QuoteService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<QuotePagination> GetQuotesAsync(string authorName, int page, int limit)
        {
            var responseString = await _httpClient.GetStringAsync($"/quotes?author={authorName}&page={page}&limit={limit}");
            return JsonConvert.DeserializeObject<QuotePagination>(responseString);
        }

        public async Task<Quote> GetRandomQuoteAsync()
        {
            var responseString = await _httpClient.GetStringAsync("random");
            return JsonConvert.DeserializeObject<Quote>(responseString);
        }
    }
}
