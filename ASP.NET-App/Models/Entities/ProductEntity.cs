using System.ComponentModel.DataAnnotations;

namespace ASP.NET_App.Models.Entities;

public class ProductEntity
{
    [Key]
    public string ArticleNumber { get; set; } = null!;

    [Required]
    public string? ProductName { get; set; }
    public string? ProductImage { get; set; }

    [Required]
    public string? Ingress { get; set; }
    public string? Description { get; set; }

    [Required]
    [DataType("money")]
    public decimal Price { get; set; }

    public ICollection<ProductCategoryEntity>? ProductCategories { get; set; }

}
