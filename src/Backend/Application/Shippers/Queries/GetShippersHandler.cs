using Application.Abstractions;
using Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Shippers.Queries
{
    internal class GetShippersHandler : IRequestHandler<GetShippersQuery, IEnumerable<Shipper>>
    {
        private readonly IApplicationRepositoryManager _applicationRepositoryManager;
        public GetShippersHandler(IApplicationRepositoryManager applicationRepositoryManager)
        {
            _applicationRepositoryManager = applicationRepositoryManager;
        }

        public async Task<IEnumerable<Shipper>> Handle(GetShippersQuery request, CancellationToken cancellationToken)
        {
            var a = await _applicationRepositoryManager.ShipperRepository.GetShipperShipmentsAsync(1);

            return await _applicationRepositoryManager.ShipperRepository.GetShippersAsync();
        }
    }
}