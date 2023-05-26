using ASP.NET_App.Models.ViewModels;
using ASP.NET_App.Services;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_App.Controllers
{
    public class RegisterController : Controller
    {

        private readonly AuthenticationService _auth;

        public RegisterController(AuthenticationService auth)
        {
            _auth = auth;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(RegisterViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                if (await _auth.UserAlreadyExistsAsync(viewModel))
                    ModelState.AddModelError("", "An account with the same email already exisists. ");

                if (await _auth.RegisterUserAsync(viewModel))
                    return RedirectToAction("index", "login");
            }

            return View(viewModel);

        }

    }
}

