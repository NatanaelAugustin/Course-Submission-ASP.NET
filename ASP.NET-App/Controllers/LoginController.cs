using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_App.Controllers
{
	public class LoginController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
