using System;
using Application.Messaging;
using Infrastructure.Services;
using SendGrid.Helpers.Mail;

namespace Application.Features.AppEntities.EmailFeatures.Commands.TesEmail
{
	public class TestEmailCommandHandler:ICommandHandler<TestEmailCommand,TestEmailCommandResponse>
	{
		public TestEmailCommandHandler()
		{
		}

        public async Task<TestEmailCommandResponse> Handle(TestEmailCommand request, CancellationToken cancellationToken)
        {
            List<EmailAddress> tos = new List<EmailAddress>();
            tos.Add(new EmailAddress("alanyalialper@gmail.com"));
            var result = await EmailSenderService.SendEmail("Test", "Test 123", tos);

            return new();
        }
    }
}

