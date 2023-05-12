using ASP.NET_App.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_App.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			var viewModel = new HomeIndexViewModel
			{
				BestCollection = new GridCollectionViewModel
				{
					Title = "Our Selection",
					Categories = new List<string> { "new, popular, featured" },
					GridItems = new List<GridCollectionItemViewModel>
					{
						new GridCollectionItemViewModel { Id = "1" , Title = "Computer", Price = 10, ImageUrl = "images/placeholders/270x295.svg" },
						new GridCollectionItemViewModel { Id = "2" , Title = "Computer", Price = 20, ImageUrl = "images/placeholders/270x295.svg" },
						new GridCollectionItemViewModel { Id = "3" , Title = "Computer", Price = 30, ImageUrl = "images/placeholders/270x295.svg" },
						new GridCollectionItemViewModel { Id = "4" , Title = "Computer", Price = 40, ImageUrl = "images/placeholders/270x295.svg" },
						new GridCollectionItemViewModel { Id = "5" , Title = "Computer", Price = 50, ImageUrl = "images/placeholders/270x295.svg" },
						new GridCollectionItemViewModel { Id = "6" , Title = "Computer", Price = 60, ImageUrl = "images/placeholders/270x295.svg" },
						new GridCollectionItemViewModel { Id = "7" , Title = "Computer", Price = 70, ImageUrl = "images/placeholders/270x295.svg" },
						new GridCollectionItemViewModel { Id = "8" , Title = "Computer", Price = 80, ImageUrl = "images/placeholders/270x295.svg" }
					}

				}
			};

			return View(viewModel);
		}
	}
}
