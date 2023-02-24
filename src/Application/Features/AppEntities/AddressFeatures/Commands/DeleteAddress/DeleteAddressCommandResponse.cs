using System;
namespace Application.Features.AppEntities.AddressFeatures.Commands.DeleteAddress
{
	public sealed record DeleteAddressCommandResponse(
		string Message ="Kayit başarılı ile silindi"
		);
	
}

