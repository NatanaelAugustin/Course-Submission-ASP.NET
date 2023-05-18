namespace CourseSubmission.Models.Dtos;

public class DtoProduct
{
    public string? ArticleNumber { get; set; }
    public string? ProductName { get; set; }
    public string? Ingress { get; set; }
    public string? Description { get; set; }
    public decimal? Price { get; set; }
    public byte[]? ProductImage { get; set; }
    public List<int> Categories { get; set; } = new List<int>();
}