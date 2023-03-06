using System;
using System.ComponentModel.DataAnnotations.Schema;
using Domain.Abstractions;
using Domain.Entities.Identity;

namespace Domain.Entities
{
	public class Basket:Entity
	{

		public Basket()
		{

		}
		public Basket(Guid userId,decimal totalAmount)
		{
			Id = Guid.NewGuid();
			UserId = userId;
			TotalAmount = totalAmount;

		}
		public ICollection<BasketItem> BasketItems { get; set; }

		[ForeignKey("AppUser")]
		public Guid UserId { get; set; }
		public AppUser User { get; set; }

		public decimal TotalAmount { get; set; }

		
		public virtual ICollection<Order> Orders { get; set; }
	}
}

