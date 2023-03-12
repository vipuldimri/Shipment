using Application.Abstractions;
using Domain.Entities;
using Domain.Parameters;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Quotes.Queries
{
    internal class GetQuotesHandler : IRequestHandler<GetQuotesQuery, QuotePagination>
    {
        private readonly IQuoteService _quoteService;
        public GetQuotesHandler(IQuoteService quoteService)
        {
            _quoteService = quoteService;
        }

        public async Task<QuotePagination> Handle(GetQuotesQuery request, CancellationToken cancellationToken)
        {
            return await _quoteService.GetQuotesAsync(   authorName: request.AuthorName,
                                                         page: request.Page,
                                                         limit: request.Limit
                                                     );
        }
    }
}