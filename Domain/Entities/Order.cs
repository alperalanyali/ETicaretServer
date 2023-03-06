using System;
using System.ComponentModel.DataAnnotations.Schema;
using Domain.Abstractions;
using Domain.Entities.Identity;

namespace Domain.Entities
{
	public class Order:Entity
	{
		public Order()
		{

		}

		public Order(Guid userId,Guid addressId,Guid paymentTypeId)
		{
			Id = Guid.NewGuid();			
			UserId = userId;
			AddressId = addressId;
			PaymentTypeId = paymentTypeId;

		}
		public List<OrderItem> OrderItems { get; set; }

		[ForeignKey("UserId")]
		public Guid UserId { get; set; }
		public AppUser User { get; set; }

		public Guid AddressId { get; set; }
		public Address Address { get; set; }

		[ForeignKey("PaymentTypes")]
		public Guid PaymentTypeId { get; set; }
		public PaymentType PaymentType { get; set; }
	}
}

