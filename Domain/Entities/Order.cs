using System;
using System.ComponentModel.DataAnnotations.Schema;
using Domain.Abstractions;

namespace Domain.Entities
{
	public class Order:Entity
	{
		public Order()
		{

		}

		public Order(Guid basketId,Guid addressId,Guid paymentTypeId)
		{
			Id = Guid.NewGuid();
			BasketId = basketId;
			AddressId = addressId;
			PaymentTypeId = paymentTypeId;

		}
		public List<OrderItem> OrderItems { get; set; }
		[ForeignKey("Baskets")]
		public Guid BasketId { get; set; }
		public Basket Basket { get; set; }

		public Guid AddressId { get; set; }
		public Address Address { get; set; }

		[ForeignKey("PaymentTypes")]
		public Guid PaymentTypeId { get; set; }
		public PaymentType PaymentType { get; set; }
	}
}

