using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ASP.NET_App.Models.Contexts
{
	public class AppContexts : IdentityDbContext
	{
		public AppContexts(DbContextOptions<AppContexts> options) : base(options)
		{
		}
	}
}
