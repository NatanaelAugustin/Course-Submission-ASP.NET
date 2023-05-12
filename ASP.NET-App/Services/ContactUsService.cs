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

		public async Task<bool> ContactUsAsync(ContactUsViewModel viewModel)
		{
			try
			{
				var contactUsEntity = new ContactUsEntity
				{
					FirstName = viewModel.FirstName,
					LastName = viewModel.LastName,
					Email = viewModel.Email,
					PhoneNumber = viewModel.PhoneNumber,
					Message = viewModel.Message
				};

				_context.ContactUs.Add(contactUsEntity);
				await _context.SaveChangesAsync();
				return true;
			}
			catch (Exception ex)
			{
				// Log the exception
				return false;
			}
		}
	}
}
