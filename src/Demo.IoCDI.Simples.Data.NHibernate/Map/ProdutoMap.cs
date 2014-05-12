using Demo.IoCDI.Simples.Dominio.Entidades;
using FluentNHibernate.Mapping;

namespace Demo.IoCDI.Simples.Data.NHibernate.Map
{
    public class ProdutoMap : ClassMap<Produto>
    {
        public ProdutoMap()
        {
            Table("tbProd");

            Id(x => x.ID)
            .GeneratedBy.Identity()
            .Column("IDProd");

            this.Map(x => x.Nome)
            .Not.Nullable()
            .Length(100).Column("NomeProd");

            this.Map(x => x.Descricao)
            .Not.Nullable()
            .Length(150)
            .Column("DescProd");

            this.Map(x => x.Preco)
            .Not.Nullable()
            .Column("PrecoProd");

            this.Map(x => x.Categoria)
            .Not.Nullable()
            .Length(50)
            .Column("CatProd");

        }
    }
}
