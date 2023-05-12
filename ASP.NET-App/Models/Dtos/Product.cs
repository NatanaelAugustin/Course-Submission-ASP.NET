using System.ComponentModel.DataAnnotations;

namespace ASP.NET_App.Models.Dtos
{
	public class Product
	{
		[Key]
		public string? ArticleNumber { get; set; } 
		public string? ProductName { get; set; }
		public string? Ingress { get; set; }
		public string? Description { get; set; }

		public List<string> Tags { get; set; } = new List<string>();


	}
}
