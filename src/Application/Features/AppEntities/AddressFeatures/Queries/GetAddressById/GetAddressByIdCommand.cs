using System;
using Application.Messaging;

namespace Application.Features.AppEntities.AddressFeatures.Queries.GetAddressById
{
	public sealed record GetAddressByIdCommand(
		string Id
		):ICommand<GetAddressByIdCommandResponse>;
	
}

