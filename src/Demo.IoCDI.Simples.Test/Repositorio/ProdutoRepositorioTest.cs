using Microsoft.VisualStudio.TestTools.UnitTesting;
using Demo.IoCDI.Simples.Dominio.Entidades;
using Demo.IoCDI.Simples.Dominio.Interfaces;
using System.Collections;
using System.Collections.Generic;
using Moq;

namespace Demo.IoCDI.Simples.Test.Repositorio
{
    [TestClass]
    public class ProdutoRepositorioTest
    {
        private IProdutoRepositorio MockProdutoRepositorio { get; set; }

        public ProdutoRepositorioTest()
        {
            //produtos mock
            IList<Produto> prods = 
                new List<Produto> { 
                    new Produto{ID = 1, Nome = "produto 1", Descricao = "descrição prod 1", Categoria = "cat 1", Preco = 1.99M},
                    new Produto{ID = 2, Nome = "produto 2", Descricao = "descrição prod 2", Categoria = "cat 1", Preco = 10.99M},
                    new Produto{ID = 3, Nome = "produto 3", Descricao = "descrição prod 3", Categoria = "cat 2", Preco = 19.9M},
                    new Produto{ID = 4, Nome = "produto 4", Descricao = "descrição prod 4", Categoria = "cat 2", Preco = 199.0M},
                    new Produto{ID = 5, Nome = "produto 5", Descricao = "descrição prod 5", Categoria = "cat 1", Preco = .99M},
                };

            // Repositório fake
            var mockProdutoRepositorio = new Mock<IProdutoRepositorio>();

            // Retornando todos os prods
            mockProdutoRepositorio.Setup(mr => mr.Produtos).Returns(prods);

            /*
             * TO DO --> montar setup dos outros métodos no repositório!
             */


            // Complete the setup of our Mock Product Repository
            this.MockProdutoRepositorio = mockProdutoRepositorio.Object;

        }

        [TestMethod]
        public void Retornando_Lista_de_todos_os_Produtos()
        {
            IList<Produto> testProds = this.MockProdutoRepositorio.Produtos;

            Assert.IsNotNull(testProds); // testando se tá nulo
            Assert.AreEqual(5, testProds.Count); // comprando o n. de itens
        }

    }
}
