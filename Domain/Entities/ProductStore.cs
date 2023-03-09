using System;
using System.ComponentModel.DataAnnotations.Schema;
using Domain.Abstractions;

namespace Domain.Entities
{
	public class ProductStore:Entity
	{
		[ForeignKey("Product")]
		public Guid ProductId { get; set; }
		public Product Product { get; set; }

		
		public Guid StoreId { get; set; }
		
	}
}

