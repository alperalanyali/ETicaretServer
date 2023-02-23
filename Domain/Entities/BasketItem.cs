using System;
using System.ComponentModel.DataAnnotations.Schema;
using Domain.Abstractions;

namespace Domain.Entities
{
	public class BasketItem:Entity
	{
		public BasketItem()
		{

		}

		public BasketItem(Guid basketId,Guid productId,decimal quantity,decimal totalPrice)
		{
			BasketId = basketId;
			ProductId = productId;
			Quantity = quantity;
			TotalPrice = totalPrice;
		}

		[ForeignKey("Baskets")]
		public Guid BasketId { get; set; }
		public Basket Basket { get; set; }

		[ForeignKey("Products")]
		public Guid ProductId { get; set; }
		public Product Product { get; set; }
		public decimal Quantity { get; set; }
		public decimal TotalPrice { get; set; }
	}
}

