using System;
using System.ComponentModel.DataAnnotations.Schema;
using Domain.Abstractions;

namespace Domain.Entities
{
	public class ProductCategory:Entity
	{
		public ProductCategory()
		{

		}

		public ProductCategory(Guid productId,Guid categoryId)
		{
			Id = Guid.NewGuid();
			ProductId = productId;
			CategoryId = categoryId;
		}
		//[ForeignKey("Product")]
		public Guid ProductId { get; set; }
		//public Product Product { get; set; }

		[ForeignKey("Category")]
		public Guid CategoryId { get; set; }
		public Category Category { get; set; }
	}
}

