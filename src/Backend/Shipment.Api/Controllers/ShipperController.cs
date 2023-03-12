using Application.Shippers.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Shipment.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ShipperController : Controller
    {
        private readonly ILogger<QuoteController> _logger;
        private readonly IMediator _mediator;

        public ShipperController(ILogger<QuoteController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _mediator.Send(new GetShippersQuery()));
        }

        [HttpGet("{shipperId}/Shipment")]
        public async Task<IActionResult> Get(int shipperId)
        {
            return Ok(await _mediator.Send(new GetShipmentByShipperIdQuery()
            {
                ShipperId = shipperId
            }));
        }
    }
}
