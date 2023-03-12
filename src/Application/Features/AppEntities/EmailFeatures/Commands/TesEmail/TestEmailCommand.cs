using System;
using Application.Messaging;

namespace Application.Features.AppEntities.EmailFeatures.Commands.TesEmail
{
	public sealed record TestEmailCommand(

		):ICommand<TestEmailCommandResponse>;
	
}

