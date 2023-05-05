using ASP.NET_App.Models.Entities;
using ASP.NET_App.Models.Identities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ASP.NET_App.Models.Contexts
{
	public class AppContexts : IdentityDbContext<AppUser>
	{
		public AppContexts(DbContextOptions<AppContexts> options) : base(options)
		{
		}

		public DbSet<AddressEntity> AspNetAdresses { get; set; }

		public DbSet<UserAddressEntity> AspNetUsersAdresses { get; set; }
	}
}
