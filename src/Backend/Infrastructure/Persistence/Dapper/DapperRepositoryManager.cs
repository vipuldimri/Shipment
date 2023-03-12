using Application.Abstractions;
using Infrastructure.Persistence.Dapper.Repositories;

namespace Infrastructure.Persistence.Dapper
{
    public class DapperRepositoryManager: IApplicationRepositoryManager
    {
        private IShipperRepository _shipperRepository;

        private readonly IDatabaseConnectionFactory _sqlConnectionFactory;

        public DapperRepositoryManager(IDatabaseConnectionFactory connectionFactory)
        {
                _sqlConnectionFactory= connectionFactory;
        }

        public IShipperRepository ShipperRepository
        {
            get
            {
                _shipperRepository ??= new ShipperRepository(_sqlConnectionFactory);
                return _shipperRepository;
            }
        }
    }
}
