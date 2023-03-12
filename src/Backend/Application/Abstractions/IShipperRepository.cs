using Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Abstractions
{
    public interface IShipperRepository
    {
        public Task<IEnumerable<Shipper>> GetShippersAsync();
        public Task<IEnumerable<Shipment>> GetShipperShipmentsAsync(int shipperId);

    }
}
