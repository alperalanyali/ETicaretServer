using System;
using System.ComponentModel.DataAnnotations.Schema;
using Domain.Abstractions;

namespace Domain.Entities
{
	public class OrderItem:Entity
	{
        public OrderItem()
        {

        }
        public OrderItem(Guid orderId,Guid productStoreId,decimal quantity,decimal totalPrice)
        {
            OrderId = orderId;
            ProductStoreId = productStoreId;
            Quantity = quantity;
            TotalPrice = totalPrice;
        }


        //[ForeignKey("Orders")]
        public Guid OrderId { get; set; }
        //public Order Order { get; set; }

        [ForeignKey("ProductStores")]
        public Guid ProductStoreId { get; set; }
        public ProductStore ProductStore { get; set; }
        public decimal Quantity { get; set; }
        public decimal TotalPrice { get; set; }
    }
}

