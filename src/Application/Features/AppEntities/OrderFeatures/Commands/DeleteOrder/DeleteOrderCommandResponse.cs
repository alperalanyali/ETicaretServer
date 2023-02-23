using System;
namespace Application.Features.AppEntities.OrderFeatures.Commands.DeleteOrder
{
	public sealed record DeleteOrderCommandResponse(
		string Message = "Ürün siparişten kaldırıldı"
		);
	
}

