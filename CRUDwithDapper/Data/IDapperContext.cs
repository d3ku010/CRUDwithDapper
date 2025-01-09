using System.Data;

namespace CRUDwithDapper.Data
{
    public interface IDapperContext
    {
        IDbConnection CreateConnection();

    }
}
