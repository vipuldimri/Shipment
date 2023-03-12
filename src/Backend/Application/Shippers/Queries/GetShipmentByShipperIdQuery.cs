using Domain.Entities;
using MediatR;
using System.Collections.Generic;

namespace Application.Shippers.Queries
{
    public class GetShipmentByShipperIdQuery : IRequest<IEnumerable<Shipment>>
    {
        public int ShipperId { get; set; }
    }
}
