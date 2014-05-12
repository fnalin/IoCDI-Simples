using Microsoft.VisualStudio.TestTools.UnitTesting;
using Demo.IoCDI.Simples.Dominio.Entidades;
using System.Collections.Generic;
using Demo.IoCDI.Simples.UI.AspNetMVC.Controllers;

namespace Demo.IoCDI.Simples.Test.UI
{
    [TestClass]
    public class HomeControllerUITest
    {
        [TestMethod]
        public void Testando_Get_com_ADO()
        {
            // Arrange - create a controller
            HomeController controller = new HomeController();

            // Action
            var result = controller.Get("ADO");

            // Assert
            Assert.IsNotNull(((IList<Produto>)result.ViewData.Model));
        }
    }
}
