using Microsoft.AspNetCore.Mvc;
using PhoogleZero.Web.Controllers;

namespace PhoogleZero.Web.Public.Controllers
{
    public class HomeController : PhoogleZeroControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}