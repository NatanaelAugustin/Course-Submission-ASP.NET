﻿namespace ASP.NET_App.Models.Entities
{
	public class ImageEntity
	{
		public int Id { get; set; }
		public string ImageName { get; set; } = null!;
		public ICollection<ProductImageEntity> Products { get; } = new HashSet<ProductImageEntity>();
	}
}