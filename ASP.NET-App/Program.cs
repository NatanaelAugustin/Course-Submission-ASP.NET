using ASP.NET_App.Models.Contexts;
using ASP.NET_App.Models.Identities;
using ASP.NET_App.Repositories;
using ASP.NET_App.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
// Contexts
builder.Services.AddDbContext<AppContexts>(optionsBuilder => optionsBuilder.UseSqlServer(builder.Configuration.GetConnectionString("Sql")));

// Repositories
builder.Services.AddScoped<AddressRepository>();
builder.Services.AddScoped<UserAddressRepository>();
builder.Services.AddScoped<ProductRepository>();

// Services
builder.Services.AddScoped<ShowcaseService>();
builder.Services.AddScoped<AddressService>();
builder.Services.AddScoped<AuthenticationService>();
builder.Services.AddScoped<SeedService>();
builder.Services.AddScoped<IContactUsService, ContactUsService>();

// Identity
builder.Services.AddIdentity<AppUser, IdentityRole>(x =>
{
    x.SignIn.RequireConfirmedAccount = false;
    x.Password.RequiredLength = 8;
    x.User.RequireUniqueEmail = true;
}).AddEntityFrameworkStores<AppContexts>()
    .AddClaimsPrincipalFactory<CustomClaimsPrincipalFactory>();

// Cookies
builder.Services.ConfigureApplicationCookie(x =>
{
    x.LoginPath = "/login";
    x.LogoutPath = "/";
    x.AccessDeniedPath = "/denied";
});

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    // Get the SeedService instance
    var seedService = services.GetRequiredService<SeedService>();

    // Call the SeedCategories method
    await seedService.SeedCategories();

    // ...
}
app.UseHsts();
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
