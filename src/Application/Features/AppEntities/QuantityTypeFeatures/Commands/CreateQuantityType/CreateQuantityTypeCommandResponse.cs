using System;
namespace Application.Features.AppEntities.QuantityTypeFeatures.Commands.CreateQuantityType
{
	public sealed record CreateQuantityTypeCommandResponse(
		string Message = "Ölçü birimi eklendi"
		);

}

