using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASP.NET_App.Models.Entities;

public class ProductCategoryEntity
{

    [Key]
    public int Id { get; set; }

    [ForeignKey("Product")]
    public string? ProductArticleNumber { get; set; }

    [ForeignKey("Category")]
    public int CategoryId { get; set; }

    public ProductEntity? Product { get; set; }
    public CategoryEntity? Category { get; set; }

}


