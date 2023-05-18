using ASP.NET_App.Models.Contexts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_App.Controllers
{
    [Authorize(Roles = "admin")]
    public class AdminController : Controller
    {
        private readonly AppContexts _appcontexts;
        public AdminController(AppContexts appcontexts)
        {
            _appcontexts = appcontexts;
        }

        [HttpGet("admin")]
        public IActionResult Index()
        {
            return View(_appcontexts.Users.ToList());
        }

    }
}
