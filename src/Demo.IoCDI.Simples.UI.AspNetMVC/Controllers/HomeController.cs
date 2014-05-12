using Demo.IoCDI.Simples.Dominio;
using Demo.IoCDI.Simples.Dominio.Entidades;
using Demo.IoCDI.Simples.Dominio.Interfaces;
using Demo.IoCDI.Simples.Infra;
using Ninject;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Demo.IoCDI.Simples.UI.AspNetMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }


        public PartialViewResult Get(string id)
        {
            var dados = RetornarDados(id);
            return PartialView("_relacaoProdutos", dados);
        }

        private IList<Produto> RetornarDados(string tipo)
        {
            var _tipo = (Enums.BindContainner)Enum.Parse(typeof(Enums.BindContainner), tipo);

            IKernel kernel = new InfraKernel(_tipo);
            var servico = kernel.Get<IProdutoRepositorio>();

            return servico.Produtos;

        }

        public ActionResult About()
        {
            ViewBag.Message = "Demo.IoCDI.Simples.UI.AspNetMVC";
            return View();
        }
    }
}