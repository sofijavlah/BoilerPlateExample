using Microsoft.AspNetCore.Mvc;

namespace BoilerPlateExample.Web.Controllers
{
    public class HomeController : BoilerPlateExampleControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
        
    }
}