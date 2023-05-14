using ASP.NET_App.Models.Contexts;
using ASP.NET_App.Models.ViewModels;
using ASP.NET_App.Services;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_App.Controllers
{
	public class ContactUsController : Controller
	{
		private readonly ContactUsService _contactUsService;
		private readonly AppContexts _appContexts;
		private readonly ILogger<ContactUsService> _logger;

		public ContactUsController(ContactUsService contactUsService, AppContexts appContexts, ILogger<ContactUsService> logger)
		{
			_contactUsService = contactUsService;
			_appContexts = appContexts;
			_logger = logger;
		}

		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> ContactUS(ContactUsViewModel viewModel)
		{


			if (ModelState.IsValid)
			{
				_logger.LogInformation("Saving contact us entity");
				try
				{
					await _contactUsService.CreateAsync(viewModel);
					return RedirectToAction("Index");
				}
				catch
				{
					ModelState.AddModelError("", "Something went wrong, please try again");
				}
			}

			return View(viewModel);
		}
	}
}
