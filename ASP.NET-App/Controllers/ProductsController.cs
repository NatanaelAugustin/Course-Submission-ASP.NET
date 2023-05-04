using ASP.NET_App.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_App.Controllers
{
	public class ProductsController : Controller
	{

		public IActionResult Index()
		{
			var viewModel = new ProductsIndexViewModel
			{
				All = new GridCollectionViewModel
				{
					Title = "All Products",
					Categories = new List<string> { "New", "Best selling", "Featured" }
				}
			};
			return View(viewModel);
		}
		public IActionResult Details(string id)
		{
			return View();
		}
	}

}
