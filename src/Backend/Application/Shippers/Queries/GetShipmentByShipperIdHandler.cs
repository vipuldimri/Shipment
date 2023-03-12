using Application.Abstractions;
using Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Shippers.Queries
{
    internal class GetShipmentByShipperIdHandler : IRequestHandler<GetShipmentByShipperIdQuery, IEnumerable<Shipment>>
    {
        private readonly IApplicationRepositoryManager _applicationRepositoryManager;
        public GetShipmentByShipperIdHandler(IApplicationRepositoryManager applicationRepositoryManager)
        {
            _applicationRepositoryManager = applicationRepositoryManager;
        }

        public async Task<IEnumerable<Shipment>> Handle(GetShipmentByShipperIdQuery request, CancellationToken cancellationToken)
        {
            return await _applicationRepositoryManager.ShipperRepository.GetShipperShipmentsAsync(request.ShipperId);
        }
    }
}