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
        public OrderItem(Guid orderId,Guid productId,decimal quantity,decimal totalPrice)
        {
            OrderId = orderId;
            ProductId = productId;
            Quantity = quantity;
            TotalPrice = totalPrice;
        }


        [ForeignKey("Orders")]
        public Guid OrderId { get; set; }
        public Order Order { get; set; }

        [ForeignKey("Products")]
        public Guid ProductId { get; set; }
        public Product Product { get; set; }
        public decimal Quantity { get; set; }
        public decimal TotalPrice { get; set; }
    }
}

