using System;
using Application.Services;
using Domain.Dtos;
using Iyzipay;
using Iyzipay.Model;
using Iyzipay.Request;
using OnlinePayment_Iyzico.Abstract;
using OnlinePayment_Iyzico.Dto;

namespace OnlinePayment_Iyzico.Services
{
	public class PaymenyService:IPaymentService
	{
		private readonly IIyzicoSettingsService _iyzicoService;
		public PaymenyService(IIyzicoSettingsService ıyzicoSettingsService)
		{
			_iyzicoService = ıyzicoSettingsService;
		}
		public async Task<PaymentResult> PaymentWithIyzico(PaymentAddressDto paymentAddressDto)
		{
			var result = await _iyzicoService.GetFirstAsync();
			Options options = new Options();
			options.ApiKey = result.Api;
			options.SecretKey = result.SecretKey;
			options.BaseUrl = result.BaseUrl;

            CreatePaymentRequest request = new CreatePaymentRequest();
            request.Locale = Locale.TR.ToString();
            request.ConversationId = "123456789";
            request.Price = paymentAddressDto.Price.ToString();
            request.PaidPrice = paymentAddressDto.Price.ToString();
            request.Currency = Currency.TRY.ToString();
            request.Installment = 1;
            request.BasketId = "B67832";
            request.PaymentChannel = PaymentChannel.WEB.ToString();
            request.PaymentGroup = PaymentGroup.PRODUCT.ToString();


            PaymentCard paymentCard = new PaymentCard();
            paymentCard.CardHolderName = paymentAddressDto.CardHolderName;
            paymentCard.CardNumber = paymentAddressDto.CardNumber;
            paymentCard.ExpireMonth = paymentAddressDto.ExpireMonth;
            paymentCard.ExpireYear = paymentAddressDto.ExpireYear;
            paymentCard.Cvc = paymentAddressDto.Cvc;
            paymentCard.RegisterCard = 0;
            request.PaymentCard = paymentCard;


            Buyer buyer = new Buyer();
            buyer.Id = paymentAddressDto.UserId;
            buyer.Name = paymentAddressDto.Name;
            buyer.Surname = paymentAddressDto.Surname;
            buyer.GsmNumber = paymentAddressDto.GsmNumber;
            buyer.Email = paymentAddressDto.Email;
            buyer.IdentityNumber = paymentAddressDto.IdentityNumber;
            buyer.LastLoginDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            buyer.RegistrationDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            buyer.RegistrationAddress = paymentAddressDto.RegistrationAddress;
            buyer.Ip = paymentAddressDto.Ip;
            buyer.City = paymentAddressDto.City;
            buyer.Country = paymentAddressDto.Country;
            buyer.ZipCode = paymentAddressDto.ZipCode;
            request.Buyer = buyer;

            Address shippingAddress = new Address();
            shippingAddress.ContactName = $"{paymentAddressDto.Name} {paymentAddressDto.Surname}";
            shippingAddress.City = paymentAddressDto.City;
            shippingAddress.Country = paymentAddressDto.Country;
            shippingAddress.Description = paymentAddressDto.RegistrationAddress;
            shippingAddress.ZipCode = paymentAddressDto.ZipCode;
            request.ShippingAddress = shippingAddress;

            Address billingAddress = new Address();
            billingAddress.ContactName = $"{paymentAddressDto.Name} {paymentAddressDto.Surname}";
            billingAddress.City = paymentAddressDto.City;
            billingAddress.Country = paymentAddressDto.Country;
            billingAddress.Description = paymentAddressDto.RegistrationAddress;
            billingAddress.ZipCode = paymentAddressDto.ZipCode;
            request.BillingAddress = billingAddress;


            List<BasketItem> basketItems = new List<BasketItem>();
            BasketItem firstBasketItem = new BasketItem();
            firstBasketItem.Id = paymentAddressDto.BasketId;
            firstBasketItem.Name = paymentAddressDto.Description;
            firstBasketItem.Category1 = paymentAddressDto.Description;
            firstBasketItem.Category2 = paymentAddressDto.Description;
            firstBasketItem.ItemType = BasketItemType.PHYSICAL.ToString();
            firstBasketItem.Price = paymentAddressDto.Price.ToString();
            basketItems.Add(firstBasketItem);

            request.BasketItems = basketItems;
            Payment payment = Payment.Create(request, options);

            var paymentResult = new PaymentResult(payment.Status, payment.ErrorCode, payment.ErrorGroup, payment.ErrorMessage);

            return paymentResult;
        }
	}
}

