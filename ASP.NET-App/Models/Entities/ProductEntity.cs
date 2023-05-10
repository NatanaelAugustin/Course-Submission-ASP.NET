using System.ComponentModel.DataAnnotations;

namespace ASP.NET_App.Models.Entities;

public class ProductEntity
{
	[Key]
	public string ArticleNumber { get; set; } = null!;
	public string? ProductName { get; set; }
	public string? Ingress { get; set; }
	public string? Description { get; set; }


	//public ICollection<ProductCategoryEntity> Categories { get; set; } = new HashSet<ProductCategoryEntity>();
	//public ICollection<ProductImageEntity> Images { get; set; } = new HashSet<ProductImageEntity>();
	//public ICollection<productReviewEntity> Reviews { get; set; } = new HashSet<productReviewEntity>();

}
