using Demo.IoCDI.Simples.Data.EF.Map;
using Demo.IoCDI.Simples.Dominio.Entidades;
using Demo.IoCDI.Simples.Dominio.Global;
using System.Data.Entity;

namespace Demo.IoCDI.Simples.Data.EF.Contexto
{
    public class EFDbContext:DbContext
    {
        public DbSet<Produto> Produtos { get; set; }

        public EFDbContext()
            : base(ConnectionStrings.SQLExpress)
        { }

        static EFDbContext()
        {
            Database.SetInitializer<EFDbContext>(null);
            /*Utilize esse cara abaixo para gerar a base*/
            //Database.SetInitializer<EFDbContext>(new DropCreateDatabaseIfModelChanges<EFDbContext>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ProdutoMap());
        }

    }
}
