using System;
namespace Application.Features.AppEntities.AddressFeatures.Commands.CreateAddress
{
	public sealed record CreateAddressCommandResponse(
		string Message = "Adresinizi başarılı şekilde eklendi"
		);

}

