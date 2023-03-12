using Application.Quotes.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Shipment.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class QuoteController : Controller
    {
        private readonly ILogger<QuoteController> _logger;
        private readonly IMediator _mediator;

        public QuoteController(ILogger<QuoteController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        [HttpGet("Random")]
        public async Task<IActionResult> GetRandomQuote()
        {
            var quote = await _mediator.Send(new GetRandomQuoteQuery());
            return Ok(quote);
        }

        [HttpGet]
        public async Task<IActionResult> Get(
            [FromQuery] string authorName,
            [FromQuery] int page,
            [FromQuery] int limit)
        {
            var quotes = await _mediator.Send(new GetQuotesQuery()
            {
                AuthorName = authorName,
                Page = page,
                Limit = limit,
            });
            return Ok(quotes);
        }
    }
}
