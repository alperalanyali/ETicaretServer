using System;
using Application.Messaging;

namespace Application.Features.AppEntities.PaymentTypeFeatures.Commands.CreatePaymentType
{
	public sealed record CreatePaymentTypeCommand(
			string Code,
			string Name
		):ICommand<CreatePaymentTypeCommandResponse>;

}

