using Abp.Auditing;
using Microsoft.AspNetCore.Mvc;

namespace PhoogleZero.Web.Controllers
{
    public class HomeController : PhoogleZeroControllerBase
    {
        [DisableAuditing]
        public IActionResult Index()
        {
            return Redirect("/swagger");
        }
    }
}
