using Microsoft.AspNetCore.Mvc;
using PhoogleZero.Web.Controllers;

namespace PhoogleZero.Web.Public.Controllers
{
    public class AboutController : PhoogleZeroControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}