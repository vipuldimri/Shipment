using Application.Abstractions;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Quotes.Queries
{
    internal class GetRandomQuoteHandler : IRequestHandler<GetRandomQuoteQuery, Quote>
    {
        private readonly IQuoteService _quoteService;
        public GetRandomQuoteHandler(IQuoteService quoteService)
        {
            _quoteService = quoteService;
        }

        public async Task<Quote> Handle(GetRandomQuoteQuery request, CancellationToken cancellationToken)
        {
            return await _quoteService.GetRandomQuoteAsync();
        }
    }
}