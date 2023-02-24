using System;
namespace Application.Features.AppEntities.AddressFeatures.Commands.UpdateAddress
{
	public sealed record UpdateAddressCommandResponse(
		string Message = "Kayıt başarılı şekilde güncellendi"
		);
	
}

