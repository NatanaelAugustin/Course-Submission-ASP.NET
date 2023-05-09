using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_App.Controllers
{
    public class DeniedController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
