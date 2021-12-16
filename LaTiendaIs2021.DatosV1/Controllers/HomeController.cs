using System.Web.Mvc;

namespace LaTiendaIs2021.DatosV1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
    }
}
