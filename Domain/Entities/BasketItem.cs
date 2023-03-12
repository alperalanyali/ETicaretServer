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

		public BasketItem(Guid basketId,Guid productStoreId, decimal quantity,decimal totalPrice)
		{
			Id = Guid.NewGuid();
			BasketId = basketId;
            ProductStoreId = productStoreId;
			Quantity = quantity;
			TotalPrice = totalPrice;
		}

		//[ForeignKey("Baskets")]
		public Guid BasketId { get; set; }
		//public Basket Basket { get; set; }

		[ForeignKey("ProductStores")]
		public Guid ProductStoreId { get; set; }
		public ProductStore ProductStore { get; set; }
		public decimal Quantity { get; set; }
		public decimal TotalPrice { get; set; }
	}
}

