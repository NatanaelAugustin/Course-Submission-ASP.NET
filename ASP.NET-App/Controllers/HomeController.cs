using ASP.NET_App.Models.Contexts;
using ASP.NET_App.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ASP.NET_App.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppContexts _context;

        public HomeController(AppContexts context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            // Fetch three categories with ten products each
            var categories = _context.Category
                .Include(c => c.ProductCategories)
                .ThenInclude(pc => pc.Product)
                .Take(3)
                .ToList();

            var viewModel = new HomeIndexViewModel
            {
                Categories = categories
            };

            return View(viewModel);
        }
    }
}
