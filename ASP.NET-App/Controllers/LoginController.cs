using ASP.NET_App.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_App.Controllers
{
	public class LoginController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]

		public IActionResult Index(LoginViewModel viewModel)
		{
			if (ModelState.IsValid)
			{
				return View(viewModel);
			}

			ModelState.AddModelError("", "Incorrect email or password");
			return View(viewModel);
		}
	}
}
