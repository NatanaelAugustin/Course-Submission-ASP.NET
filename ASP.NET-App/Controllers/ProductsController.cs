using ASP.NET_App.Models.Contexts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ASP.NET_App.Controllers
{
    public class ProductsController : Controller
    {
        private readonly AppContexts _context;

        public ProductsController(AppContexts context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            // Fetch all products from all categories
            var products = _context.Products.ToList();

            return View(products);
        }

        public async Task<IActionResult> Details(string id)
        {
            if (string.IsNullOrEmpty(id))
                return NotFound();

            var product = await _context.Products.FirstOrDefaultAsync(p => p.ArticleNumber == id);

            if (product == null)
                return NotFound();

            return View(product);
        }
    }
}
