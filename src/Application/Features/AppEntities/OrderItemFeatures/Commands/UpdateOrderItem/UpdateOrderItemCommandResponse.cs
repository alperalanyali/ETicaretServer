using System;
namespace Application.Features.AppEntities.OrderItemFeatures.Commands.UpdateOrderItem
{
	public sealed record UpdateOrderItemCommandResponse(
		string Message = "Siparişiniz güncellenmiştir"
		);
	
}

