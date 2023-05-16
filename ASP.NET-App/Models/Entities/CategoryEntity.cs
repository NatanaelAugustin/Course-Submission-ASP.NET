﻿using System.ComponentModel.DataAnnotations;

namespace ASP.NET_App.Models.Entities
{
	public class CategoryEntity
	{
		[Key]
		public int Id { get; set; }

		[Required]
		public string Name { get; set; }

		public ICollection<ProductCategoryEntity> ProductCategories { get; set; }
	}

}
