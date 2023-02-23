using System;
namespace Application.Features.AppEntities.PaymentTypeFeatures.Commands.CreatePaymentType
{
	public sealed record CreatePaymentTypeCommandResponse(
			string Message = "Yeni ödeme tipi eklendi"
		);
	
}

