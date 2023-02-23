using System;
using Application.Messaging;

namespace Application.Features.AppEntities.QuantityTypeFeatures.Commands.CreateQuantityType
{
	public sealed record CreateQuantityTypeCommand(
		string Code,
		string Name
		):ICommand<CreateQuantityTypeCommandResponse>;
	
}

