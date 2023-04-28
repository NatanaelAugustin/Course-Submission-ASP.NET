using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_App.Controllers
{
	public class AdminController : Controller
	{

		public IActionResult Index()
		{
			return View();
		}

	}
}
