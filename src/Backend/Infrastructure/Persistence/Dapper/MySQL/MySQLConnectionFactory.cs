
using Microsoft.Extensions.Options;
using MySql.Data.MySqlClient;
using System.Data.Common;

namespace Infrastructure.Persistence.Dapper.MySQL
{
    public sealed class MySQLConnectionFactory : IDatabaseConnectionFactory
    {
        private readonly DapperDatabaseOptions _dapperDatabaseOptions;
        public MySQLConnectionFactory(IOptions<DapperDatabaseOptions> options)
        {
            _dapperDatabaseOptions = options.Value;
        }

        public DbConnection CreateConnection()
        {
            return new MySqlConnection(_dapperDatabaseOptions.ConnectionString);
        }
    }

}
