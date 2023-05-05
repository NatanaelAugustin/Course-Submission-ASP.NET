using ASP.NET_App.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_App.Controllers
{
	public class AccountController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
		public IActionResult Register()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Register(RegisterViewModel viewModel)
		{
			return View();
		}
		public IActionResult Login()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Login(LoginViewModel viewModel)
		{
			return View();
		}
		public IActionResult Logout()
		{
			return View();
		}

	}
}

