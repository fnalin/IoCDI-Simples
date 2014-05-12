using Demo.IoCDI.Simples.Data.NHibernate.Contexto;
using Demo.IoCDI.Simples.Dominio.Entidades;
using Demo.IoCDI.Simples.Dominio.Interfaces;
using System.Collections.Generic;

namespace Demo.IoCDI.Simples.Data.NHibernate.Repositorio
{
    /*
     * Implementação do NH
     */
    public class ProdutoRepositorioNH : IProdutoRepositorio
    {
        public IList<Produto> Produtos
        {
            get { return RetornarLista(); }
        }

        private IList<Produto> RetornarLista()
        {
            var sessionFactory = NHContext.CreateSessionFactory();
            using (var session = sessionFactory.OpenSession())
            {
                var dados = session.QueryOver<Produto>();
                return dados.List<Produto>();
            }
        }

    }
}
