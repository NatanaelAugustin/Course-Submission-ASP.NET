using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_App.Controllers
{
	public class ProductsController : Controller
	{

		public IActionResult Index()
		{
			return View();
		}
		public IActionResult Details(string id)
		{
			return View();
		}
	}
}
