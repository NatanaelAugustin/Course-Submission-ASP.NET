using ASP.NET_App.Models.Entities;
using ASP.NET_App.Models.Identities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ASP.NET_App.Models.Contexts;

public class AppContexts : IdentityDbContext<AppUser>
{
    public AppContexts(DbContextOptions<AppContexts> options) : base(options)
    {
    }

    public DbSet<AddressEntity> AspNetAdresses { get; set; } = null!;

    public DbSet<UserAddressEntity> AspNetUsersAdresses { get; set; } = null!;

    public DbSet<ProductEntity> Products { get; set; } = null!;

    public DbSet<ContactUsEntity> ContactUs { get; set; } = null!;

    public DbSet<CategoryEntity> Category { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Configure the Price property in ProductEntity
        modelBuilder.Entity<ProductEntity>()
            .Property(p => p.Price)
            .HasColumnType("decimal(18,2)");
    }
}