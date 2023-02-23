using System;
namespace Application.Features.AppEntities.BasketItemFeatures.Commands.UpdateBasketItem
{
	public sealed record UpdateBasketItemCommandResponse(
		string Message = "Sepetteki ürün başarılı şekilde güncellendi"
		);
	
}

