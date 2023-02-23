using System;
namespace Application.Features.AppEntities.OrderItemFeatures.Commands.DeleteOrderItem
{
	public sealed record DeleteOrderItemCommandResponse(
		string Message = "Ürün siparişi kaldırıldı"
		);

}

