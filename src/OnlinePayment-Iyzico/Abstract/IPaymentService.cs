using System;
using Domain.Dtos;
using OnlinePayment_Iyzico.Dto;

namespace OnlinePayment_Iyzico.Abstract
{
	public interface IPaymentService
	{
        Task<PaymentResult> PaymentWithIyzico(PaymentAddressDto paymentAddressDto);

    }
}

