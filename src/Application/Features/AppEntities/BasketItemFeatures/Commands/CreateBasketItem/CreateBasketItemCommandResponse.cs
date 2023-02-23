using System;
namespace Application.Features.AppEntities.BasketItemFeatures.Commands.CreateBasketItem
{
	public sealed record CreateBasketItemCommandResponse(
		string Message = "Sepete ürün başarılı şekilde eklendi"
		);
	
}

