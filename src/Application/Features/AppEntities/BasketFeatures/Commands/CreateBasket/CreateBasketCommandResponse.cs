using System;
namespace Application.Features.AppEntities.BasketFeatures.Commands.CreateBasket
{
	public sealed record CreateBasketCommandResponse(
			int BasketCount = 0,
			string Message ="Basket başarılı şekilde oluşturuldu"
		);
	
}

