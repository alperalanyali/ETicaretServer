using System;
using Domain.Dtos;

namespace Application.Services
{
	public interface IPaymentService
	{

        Task<PaymentResult> PaymentWithIyzico(PaymentAddressDto paymentAddressDto);
    }
}

