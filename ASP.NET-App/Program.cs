using ASP.NET_App.Models.Contexts;
using ASP.NET_App.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AppContexts>(optionsBuilder => optionsBuilder.UseSqlServer(builder.Configuration.GetConnectionString("Sql")));
builder.Services.AddScoped<ShowcaseService>();

var app = builder.Build();
app.UseHsts();
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
