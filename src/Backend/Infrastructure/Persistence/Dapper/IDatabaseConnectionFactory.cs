using System.Data.Common;

namespace Infrastructure.Persistence.Dapper
{
    public interface IDatabaseConnectionFactory
    {
        DbConnection CreateConnection();
    }
}
