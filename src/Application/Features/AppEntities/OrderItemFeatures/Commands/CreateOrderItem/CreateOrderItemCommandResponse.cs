using System;
namespace Application.Features.AppEntities.OrderItemFeatures.Commands.CreateOrderItem
{
	public sealed record CreateOrderItemCommandResponse(
		string Message = "Ürün siparişe eklendi"
		);

}

