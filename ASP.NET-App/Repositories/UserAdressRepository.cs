using ASP.NET_App.Models.Contexts;
using ASP.NET_App.Models.Entities;

namespace ASP.NET_App.Repositories
{
    public class UserAddressRepository : Repository<UserAddressEntity>
    {
        public UserAddressRepository(AppContexts context) : base(context)
        {
        }
    }
}
