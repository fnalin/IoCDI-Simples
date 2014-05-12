using Demo.IoCDI.Simples.Data.NHibernate.Map;
using Demo.IoCDI.Simples.Dominio.Global;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;

namespace Demo.IoCDI.Simples.Data.NHibernate.Contexto
{
    public class NHContext
    {
        public static ISessionFactory CreateSessionFactory()
        {

            var configure = Fluently.Configure()
                                .Database(MsSqlConfiguration.MsSql2008.ConnectionString(ConnectionStrings.SQLExpress))
                                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<ProdutoMap>())
                                .BuildSessionFactory();

            return configure;
        }
    }
}
