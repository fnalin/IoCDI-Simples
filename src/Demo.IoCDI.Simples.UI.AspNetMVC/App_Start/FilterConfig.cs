using System.Web;
using System.Web.Mvc;

namespace Demo.IoCDI.Simples.UI.AspNetMVC
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
