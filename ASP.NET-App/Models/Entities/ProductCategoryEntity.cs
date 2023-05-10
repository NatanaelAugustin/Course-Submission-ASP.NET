using Microsoft.EntityFrameworkCore;

namespace ASP.NET_App.Models.Entities
{
	[PrimaryKey("ArticleNumber", "CategoryId")]
	public class ProductCategoryEntity
	{
		public string AtricleNumber = null!;
		public ProductEntity Product { get; set; } = null!;
		public int CategoryId { get; set; }
		public CategoryEntity Category { get; set; } = null!;
	}
}
