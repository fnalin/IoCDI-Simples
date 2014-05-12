using Demo.IoCDI.Simples.Dominio;
using Demo.IoCDI.Simples.Dominio.Interfaces;
using Demo.IoCDI.Simples.Infra;
using Ninject;
using System;

namespace Demo.IoCDI.Simples.UI.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //EF
            var dataEF = Enums.BindContainner.EF;

            //ADO.NET
            var dataADO = Enums.BindContainner.ADO;

            //NHibernate
            var dataNH = Enums.BindContainner.NHibernate;


            /*
             * Passe para o kernel qual q deseja utilizar
             */

            IKernel kernel = new InfraKernel(dataNH);
            var servico = kernel.Get<IProdutoRepositorio>();

            var dados = servico.Produtos;
            foreach (var item in dados)
            {
                Console.WriteLine("ID: {0} - Nome: {1} - Descrição: {2} - Valor: {3}", item.ID, item.Nome, item.Descricao, item.Preco.ToString("c2"));
            }

            Console.WriteLine("\nFim!");
            Console.ReadLine();

        }
    }
}
