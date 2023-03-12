using Application.Abstractions;
using Dapper;
using Domain.Entities;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.Dapper.Repositories
{
    internal class ShipperRepository: IShipperRepository
    {
        private readonly IDatabaseConnectionFactory _connectionFactory;

        public ShipperRepository(IDatabaseConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }

        public async Task<IEnumerable<Shipper>> GetShippersAsync()
        {
            await using var sqlConnection = _connectionFactory.CreateConnection();
            return await sqlConnection.QueryAsync<Shipper>(@"select * from SHIPPER");
        }


        public async Task<IEnumerable<Shipment>> GetShipperShipmentsAsync(int shipperId)
        {
            await using var sqlConnection = _connectionFactory.CreateConnection();

            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("shipper_id", shipperId);

            return sqlConnection.Query<Shipment>("Shipper_Shipment_Details", 
                                                            param: parameters,
                                                            commandType: CommandType.StoredProcedure);
        }
    }
}
