using ASP.NET_App.Models.Entities;
using ASP.NET_App.Models.ViewModels;
using ASP.NET_App.Services;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_App.Controllers
{
    public class ContactUsController : Controller
    {
        private readonly IContactUsService _contactUsService;

        public ContactUsController(IContactUsService contactUsService)
        {
            _contactUsService = contactUsService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(ContactUsViewModel contactUsViewModel)
        {
            if (ModelState.IsValid)
            {
                var contactUsEntity = new ContactUsEntity
                {
                    FirstName = contactUsViewModel.FirstName,
                    LastName = contactUsViewModel.LastName,
                    Email = contactUsViewModel.Email,
                    PhoneNumber = contactUsViewModel.PhoneNumber,
                    Message = contactUsViewModel.Message
                };

                await _contactUsService.SaveContactUsInfoAsync(contactUsEntity);

                return RedirectToAction("Index");
            }

            return View(contactUsViewModel);
        }

        [HttpGet]
        public IActionResult ThankYou()
        {
            return View();
        }
    }
}