using ASP.NET_App.Models.Entities;

namespace ASP.NET_App.Models.ViewModels;

public class HomeIndexViewModel
{
    public string Title { get; set; } = "Home";
    public List<CategoryEntity>? Categories { get; set; }
}