using System;
namespace Application.Features.AppEntities.OrderFeatures.Commands.UpdateOrder
{
	public sealed record UpdateOrderCommandResponse(
		string Message = "Siparişiniz başarılı şekilde güncellenmiştir"
		);
	
}

