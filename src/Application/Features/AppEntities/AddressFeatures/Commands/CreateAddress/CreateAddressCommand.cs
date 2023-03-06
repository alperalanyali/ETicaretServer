using System;
using Application.Messaging;

namespace Application.Features.AppEntities.AddressFeatures.Commands.CreateAddress
{
	public sealed record CreateAddressCommand(
			Guid UserId,
			string City,
			string Country,
			string Address1,
			string Address2,
			string ZipCode
		):ICommand<CreateAddressCommandResponse>;

}

