using System;
using Application.Messaging;

namespace Application.Features.AppEntities.AddressFeatures.Commands.UpdateAddress
{
	public sealed record UpdateAddressCommand(
		string Id,
		string City,
		string Country,
		string Address1,
		string Address2
		):ICommand<UpdateAddressCommandResponse>;
	
}

