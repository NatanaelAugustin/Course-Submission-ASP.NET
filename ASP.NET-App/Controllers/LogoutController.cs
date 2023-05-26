using ASP.NET_App.Models.Identities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_App.Controllers
{
    public class LogoutController : Controller
    {
        private readonly SignInManager<AppUser> singInManager;

        public LogoutController(SignInManager<AppUser> singInManager)
        {
            this.singInManager = singInManager;
        }

        public async Task<IActionResult> Index()
        {
            if (singInManager.IsSignedIn(User))
                await singInManager.SignOutAsync();

            return LocalRedirect("/");
        }
    }
}
