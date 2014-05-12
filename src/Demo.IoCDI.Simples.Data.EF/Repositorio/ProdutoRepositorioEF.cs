using Demo.IoCDI.Simples.Data.EF.Contexto;
using Demo.IoCDI.Simples.Dominio.Entidades;
using Demo.IoCDI.Simples.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Demo.IoCDI.Simples.Data.EF.Repositorio
{
    /*
        EF é o melhor pra mim! :)
     */
    public class ProdutoRepositorioEF : IProdutoRepositorio, IDisposable
    {
        private EFDbContext _ctx;

        public ProdutoRepositorioEF()
        {
            _ctx = new EFDbContext();
        }

        public IList<Produto> Produtos
        {
            get { return RetornarLista(); }
        }

        private IList<Produto> RetornarLista()
        {
            IList<Produto> prods = new List<Produto>();
            _ctx.Produtos.ToList().ForEach(d =>
                prods.Add(new Produto
                {
                    ID = d.ID,
                    Nome = d.Nome,
                    Descricao = d.Descricao,
                    Preco = d.Preco,
                    Categoria = d.Categoria
                }));

            return prods;
        }


        public void Dispose()
        {
            _ctx.Dispose();
        }
    }
}
