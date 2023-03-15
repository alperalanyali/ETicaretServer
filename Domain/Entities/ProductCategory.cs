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

		public ProductCategory(Guid productStoreId,Guid categoryId)
		{
			Id = Guid.NewGuid();
            ProductStoreId = productStoreId;
			CategoryId = categoryId;
		}
		//
		//
		//[ForeignKey("ProductStore")]
		public Guid ProductStoreId { get; set; }
		//public ProductStore Product { get; set; }

		[ForeignKey("Category")]
		public Guid CategoryId { get; set; }
		public Category Category { get; set; }
	}
}

