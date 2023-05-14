using System.ComponentModel.DataAnnotations;

namespace ASP.NET_App.Models.Entities;

public class ProductEntity
{
	[Key]
	public string ArticleNumber { get; set; } = null!;

	[Required]
	public string? ProductName { get; set; }

	[Required]
	public string? Ingress { get; set; }
	public string? Description { get; set; }

	[Required]
	public decimal Price { get; set; }

	public ICollection<CategoryEntity> Categories { get; set; }



}
