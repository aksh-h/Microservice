using Serbilis.Core.Helpers;

namespace Serbilis.DataAccess
{
    public class DapperEntity : EntityBase
    {
        public ConnectionType DapperConnectionType { get; set; }

        public DapperEntity(string Connection)
        {
        }
    }
}
