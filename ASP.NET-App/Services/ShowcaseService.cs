using ASP.NET_App.Models;

namespace ASP.NET_App.Services;

public class ShowcaseService
{
    private readonly List<ShowcaseModel> _showcases = new()
    {
        new ShowcaseModel()
        {
            Ingress = "WELCOME TO C-Shack",
            Title = "Top-quality computer-parts to a low price!",
            ImageUrl = "images/placeholders/Image18.svg",
            Button = new LinkButtonModel
            {
                Content = "SHOP NOW",
                Url = "/products",
            }
        },
    };


    public ShowcaseModel GetLatest()
    {
        return _showcases.LastOrDefault()!;
    }

}
