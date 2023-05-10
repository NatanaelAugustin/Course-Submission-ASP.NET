namespace ASP.NET_App.Models.Entities
{
	public class CategoryEntity
	{
		public int Id { get; set; }

		public string CategoryName { get; set; } = null!;

		public ICollection<ProductCategoryEntity> Products{ get; set; } = new HashSet<ProductCategoryEntity>();
	}
}
