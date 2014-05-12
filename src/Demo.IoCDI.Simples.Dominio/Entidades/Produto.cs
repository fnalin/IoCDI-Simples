
namespace Demo.IoCDI.Simples.Dominio.Entidades
{
    /*
        Entidade utilizada em todos projetos de persistência em Demo.IoCDI.Simples.Data.ADO
     */
    public class Produto
    {
        public virtual int ID { get; set; }
        public virtual string Nome { get; set; }
        public virtual string Descricao { get; set; }
        public virtual decimal Preco { get; set; }
        public virtual string Categoria { get; set; }
    }
}
