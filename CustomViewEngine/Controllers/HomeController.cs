using System.Web.Mvc;

namespace CustomViewEngine.UI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}