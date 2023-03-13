using System;
namespace Domain.Dtos
{
	public class PaymentAddressDto
    {
        public PaymentAddressDto()
        {

        }

        public PaymentAddressDto(string name,string surname,string gsmNumber,string email,string identityNumber,string ip,string city,string country,string zipCode,string userId,string cardHolderName,string cardNumber,string expireMonth,string expireYear,string cvc, decimal price, string basketId,string description,string registrationAddress)
        {
            Name = name;
            Surname = surname;
            GsmNumber = gsmNumber;
            Email = email;
            IdentityNumber = identityNumber;
            Ip = ip;
            City = city;
            Country = country;
            ZipCode = zipCode;
            UserId = userId;
            CardHolderName = cardHolderName;
            CardNumber = cardNumber;
            ExpireMonth = expireMonth;
            ExpireYear = expireYear;
            Cvc = cvc;
            Price = price;
            BasketId = basketId;
            Description = description;
            RegistrationAddress = registrationAddress;

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

        public string CardHolderName { get; set; }
        public string CardNumber { get; set; }
        public string ExpireMonth { get; set; }
        public string ExpireYear { get; set; }
        public string Cvc { get; set; }

        public decimal Price { get; set; }
        public string BasketId { get; set; }
        public string Description { get; set; }
    }
}

