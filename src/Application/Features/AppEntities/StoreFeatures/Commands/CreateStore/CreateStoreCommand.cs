using System;
using Application.Messaging;

namespace Application.Features.AppEntities.StoreFeatures.Commands.CreateStore
{
	public sealed record CreateStoreCommand(
		string StoreName,
		string Name,
		string Surname,
		string GsmNumber,
		string Email,
		string IdentityNumber,
		string RegistrationAddress,
		string ZipCode,
		string Ip,
		string City,
		string Country,
		string UserId
		):ICommand<CreateStoreCommandResponse>;

}

