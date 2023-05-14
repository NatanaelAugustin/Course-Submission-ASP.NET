using ASP.NET_App.Models.Contexts;
using ASP.NET_App.Models.Entities;
using ASP.NET_App.Models.ViewModels;

namespace ASP.NET_App.Services
{
	public class ContactUsService
	{
		private readonly AppContexts _context;

		public ContactUsService(AppContexts context)
		{
			_context = context;
		}

		public async Task<bool> CreateAsync(ContactUsViewModel viewModel)
		{
			try
			{
				ContactUsEntity contactUsEntity = viewModel;


				_context.ContactUs.Add(contactUsEntity);
				await _context.SaveChangesAsync();
				return true;
			}
			catch { return false; }
		}
	}
}
