using System.Web;
using System.Web.Mvc;

namespace LaTiendaIS2021.Datos
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
