using System.Web.Mvc;

namespace AppCotarBem.Controllers
{
    public class HomeController : Controller
    {
        public ActionResul Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
    }
}
