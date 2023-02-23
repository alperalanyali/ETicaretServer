using System;
namespace Application.Features.AppEntities.BasketItemFeatures.Commands.DeleteBasketItem
{
	public sealed record DeleteBasketItemCommandResponse(
			string Message = "Ürün sepetinizden kaldırıldı"
		);
	
}

