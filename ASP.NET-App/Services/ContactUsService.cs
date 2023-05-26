using ASP.NET_App.Models.Contexts;
using ASP.NET_App.Models.Entities;

namespace ASP.NET_App.Services
{
    public interface IContactUsService
    {
        Task SaveContactUsInfoAsync(ContactUsEntity contactUsEntity);
    }

    public class ContactUsService : IContactUsService
    {
        private readonly AppContexts _context;

        public ContactUsService(AppContexts context)
        {
            _context = context;
        }

        public async Task SaveContactUsInfoAsync(ContactUsEntity contactUsEntity)
        {
            _context.ContactUs.Add(contactUsEntity);
            await _context.SaveChangesAsync();
        }
    }
}

