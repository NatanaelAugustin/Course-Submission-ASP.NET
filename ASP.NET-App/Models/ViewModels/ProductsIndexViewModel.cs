namespace ASP.NET_App.Models.ViewModels
{
	public class ProductsIndexViewModel
	{
		public string Title { get; set; } = "Products";
		public GridCollectionViewModel All { get; set; } = null!;
	}
}
