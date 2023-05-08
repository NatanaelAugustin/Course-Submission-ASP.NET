using ASP.NET_App.Models.Contexts;
using ASP.NET_App.Models.Entities;

namespace ASP.NET_App.Repositories
{
    public class AddressRepository : Repository<AddressEntity>
    {
        public AddressRepository(AppContexts context) : base(context)
        {

        }
    }
}
