using System;
using Application.Messaging;

namespace Application.Features.AppEntities.AddressFeatures.Commands.DeleteAddress
{
	public sealed record DeleteAddressCommand(
		string Id
		):ICommand<DeleteAddressCommandResponse>;
	
}

