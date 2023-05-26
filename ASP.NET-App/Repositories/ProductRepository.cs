using ASP.NET_App.Models.Contexts;
using ASP.NET_App.Models.Entities;

namespace ASP.NET_App.Repositories
{
    public class ProductRepository : Repository<ProductEntity>
    {
        public ProductRepository(AppContexts context) : base(context)
        {
        }
    }
}
