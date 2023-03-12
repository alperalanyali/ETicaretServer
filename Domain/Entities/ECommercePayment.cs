using System;
using Domain.Abstractions;

namespace Domain.Entities
{
	public class ECommercePayment:Entity
	{
		public ECommercePayment()
		{
		}
        public ECommercePayment(string name,string surname,string gsmNumber,string email,string identityNumber,string registrationAddress,string ip,string city,string country,string zipCode,string userId)
        {
            Id = Guid.NewGuid();
            Name = name;
            Surname = surname;
            GsmNumber = gsmNumber;
            Email = email;
            IdentityNumber = identityNumber;
            RegistrationAddress = registrationAddress;
            Ip = ip;
            City = city;
            Country = country;
            ZipCode = zipCode;
            UserId = userId;

        }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string GsmNumber { get; set; }
        public string Email { get; set; }
        public string IdentityNumber { get; set; }
        public string RegistrationAddress { get; set; }
        public string Ip { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string ZipCode { get; set; }
        public string UserId { get; set; }
    }
}

