using System;
using Application.Messaging;

namespace Application.Features.AppEntities.ECommercePaymentFeatures.Commands.UpdateECommercePayment
{
	public sealed record UpdateECommercePaymentCommand(
		string Id,
		string Name,
		string Surname,
		string GsmNumber,
		string Email,
		string IdentityNumber,
		string RegistrationAddress,
		string Ip,
		string City,
		string Country,
		string ZipCode,
		string UserId

		):ICommand<UpdateECommercePaymentCommandResponse>;
	
}

