using System;
namespace Application.Features.AppEntities.ECommercePaymentFeatures.Commands.UpdateECommercePayment
{
	public sealed record UpdateECommercePaymentCommandResponse(
		string Message = "Başarılı şekilde güncellendi"
		);
	
}

