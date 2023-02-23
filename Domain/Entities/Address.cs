using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Domain.Abstractions;
using Domain.Entities.Identity;

namespace Domain.Entities
{
	public class Address:Entity
	{
		public Address()
		{

		}

		public Address(Guid userId,string city,string country,string address1,string address2)
		{
			Id = Guid.NewGuid();
			UserId = userId;
			City = city;
			Country = country;
			Address1 = address1;
			Address2 = address2;
		}

		[ForeignKey("AppUser")]
		public Guid UserId { get; set; }
		public AppUser User { get; set; }
		
        [Required]
        public string City { get; set; }
        [Required]
        public string Country { get; set; }
		[Required]
		public string Address1 { get; set; }
		public string Address2 { get; set; }

	}
}

