using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_App.Controllers
{
    public class ContactUsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
