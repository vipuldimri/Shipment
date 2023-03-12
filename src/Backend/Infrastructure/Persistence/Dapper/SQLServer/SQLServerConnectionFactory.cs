using Microsoft.Extensions.Options;
using System.Data.Common;
using System.Data.SqlClient;

namespace Infrastructure.Persistence.Dapper.SQLServer
{
    public class SQLServerConnectionFactory : IDatabaseConnectionFactory
    {
        private readonly DapperDatabaseOptions _dapperDatabaseOptions;
        public SQLServerConnectionFactory(IOptions<DapperDatabaseOptions> options)
        {
            _dapperDatabaseOptions = options.Value;
        }
        public DbConnection CreateConnection()
        {
            return new SqlConnection(_dapperDatabaseOptions.ConnectionString);
        }
    }
}
