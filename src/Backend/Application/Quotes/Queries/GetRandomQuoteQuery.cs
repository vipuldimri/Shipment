using Domain.Entities;
using MediatR;

namespace Application.Quotes.Queries
{
    public class GetRandomQuoteQuery : IRequest<Quote>
    {
    }
}
