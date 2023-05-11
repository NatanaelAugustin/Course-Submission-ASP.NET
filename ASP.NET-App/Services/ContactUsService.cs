using ASP.NET_App.Models.Contexts;

namespace ASP.NET_App.Services
{
	public class ContactUsService
	{
		public readonly AppContexts _contactUsContext;

		public ContactUsService(AppContexts contactUsContext)
		{
			_contactUsContext = contactUsContext;
		}

	}

}
