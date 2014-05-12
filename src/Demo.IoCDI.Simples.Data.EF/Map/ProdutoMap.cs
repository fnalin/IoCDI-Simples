using Demo.IoCDI.Simples.Dominio.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace Demo.IoCDI.Simples.Data.EF.Map
{
    public class ProdutoMap : EntityTypeConfiguration<Produto>
    {
        public ProdutoMap()
        {
            //PK
            this.HasKey(t => t.ID);

            //Propriedades
            this.Property(t => t.Nome)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Descricao)
                .IsRequired()
                .HasMaxLength(150);

            this.Property(t => t.Preco)
                .IsRequired();

            this.Property(t => t.Categoria)
                .HasMaxLength(50);


            //Map de Tabela e Colunas
            this.ToTable("tbProd");

            this.Property(t => t.ID)
                .HasColumnName("IDProd");

            this.Property(t => t.Nome)
                .HasColumnName("NomeProd")
                .HasColumnType("varchar");

            this.Property(t => t.Descricao)
                .HasColumnName("DescProd")
                .HasColumnType("varchar");

            this.Property(t => t.Preco)
                .HasColumnName("PrecoProd")
                .HasColumnType("decimal")
                .HasPrecision(7, 2);

            this.Property(t => t.Categoria)
                .HasColumnName("CatProd")
                .HasColumnType("varchar");
        }
    }
}
