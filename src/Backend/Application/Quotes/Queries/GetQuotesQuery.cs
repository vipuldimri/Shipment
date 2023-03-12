using Domain.Parameters;
using MediatR;
using System.Collections.Generic;

namespace Application.Quotes.Queries
{
    public class GetQuotesQuery : IRequest<QuotePagination>
    {
        public string AuthorName { get; set; }
        public int Page { get; set; }
        public int Limit { get; set; }
    }
}
