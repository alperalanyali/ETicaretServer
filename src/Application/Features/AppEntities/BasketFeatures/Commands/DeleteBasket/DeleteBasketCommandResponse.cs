using System;
namespace Application.Features.AppEntities.BasketFeatures.Commands.DeleteBasket
{
	public sealed record DeleteBasketCommandResponse(
		string Message = "İşlem Başarılı"
		);
	
}

