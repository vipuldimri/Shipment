using Domain.Entities;
using Domain.Parameters;
using System.Threading.Tasks;

namespace Application.Abstractions
{
    public interface IQuoteService
    {
        public Task<Quote> GetRandomQuoteAsync();
        public Task<QuotePagination> GetQuotesAsync(string authorName , int page, int limit);
    }
}
