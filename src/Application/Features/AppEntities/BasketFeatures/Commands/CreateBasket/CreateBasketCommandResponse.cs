using System;
namespace Application.Features.AppEntities.BasketFeatures.Commands.CreateBasket
{
	public sealed record CreateBasketCommandResponse(
			string Message ="Basket başarılı şekilde oluşturuldu"
		);
	
}

