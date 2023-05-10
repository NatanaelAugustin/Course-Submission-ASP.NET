using Microsoft.EntityFrameworkCore;

namespace ASP.NET_App.Models.Entities
{
	[PrimaryKey("ArticleNumber", "ImageId")]
	public class ProductImageEntity
	{
		public string ArticleNumber { get; set; } = null!;
		public ProductEntity Product { get; set; } = null!;

		public int ImageId { get; set; }
		public ImageEntity Image { get; set; } = null!;

		public bool IsDefaultImage { get; set; }
	}
}
