using System.Data.Entity;
using System.Data.Entity.SqlServer;

namespace Demo.IoCDI.Simples.Data.EF.Contexto
{
    public class ConfigProvider : DbConfiguration
    {
        public ConfigProvider()
        {
            SetProviderServices(SqlProviderServices.ProviderInvariantName, SqlProviderServices.Instance);
        }
    }
}
