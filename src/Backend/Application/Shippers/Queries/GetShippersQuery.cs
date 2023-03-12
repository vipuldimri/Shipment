using Domain.Entities;
using MediatR;
using System.Collections.Generic;

namespace Application.Shippers.Queries
{
    public class GetShippersQuery : IRequest<IEnumerable<Shipper>>
    {
    }
}
