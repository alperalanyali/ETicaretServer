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

		public Address(Guid userId,string city,string country,string address1,string address2,string zipCode)
		{
			Id = Guid.NewGuid();
			UserId = userId;
			City = city;
			Country = country;
			Address1 = address1;
			Address2 = address2;
			ZipCode = zipCode;
		}

		[ForeignKey("AppUser")]
		public Guid UserId { get; set; }
		public AppUser User { get; set; }
		
        [Required]
		[StringLength(100)]
		
        public string City { get; set; }
        [Required]
        [StringLength(100)]
        public string Country { get; set; }
		[Required]
        [StringLength(200)]
        public string Address1 { get; set; }
        [StringLength(200)]
        public string Address2 { get; set; }

		[Required]
        [StringLength(20)]
        public string ZipCode { get; set; }

	}
}

