using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_App.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
