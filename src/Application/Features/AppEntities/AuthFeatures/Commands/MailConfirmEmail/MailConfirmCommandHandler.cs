using System;
using Application.Messaging;
using Application.Services;
using Infrastructure.Services;
using SendGrid.Helpers.Mail;

namespace Application.Features.AppEntities.AuthFeatures.Commands.MailConfirmEmail
{
	public class MailConfirmCommandHandler:ICommandHandler<SendMailConfirmCommand,MailConfirmCommandResponse>
	{
        private readonly IAuthService _authService;

        public MailConfirmCommandHandler(IAuthService authService)
        {
            _authService = authService;
        }

        public async Task<MailConfirmCommandResponse> Handle(SendMailConfirmCommand request, CancellationToken cancellationToken)
        {
            var user = await _authService.GetByEmailOrUsernameAsync(request.emailOrUsername);

            Random random = new Random();
            int result = random.Next(1000, 10000);
            user.MailConfirmCode = result.ToString();

            await _authService.Update(user, cancellationToken);

            var html = $@" <div class=""container text-center"">
                        <h1>Tebrikler</h1>
                        <p>Kaydınızı tamamlamak için son bir adım kaldı. Aşağıdaki linke tıklayarak mail adresinizi onaylayabilir ve uygulamızı ücretsiz şekilde kullanabilirsiniz</p>
                        <hr>
                        <a href=""http://localhost:4200/mailConfirm/{user.MailConfirmCode}"" class=""btn btn-primary"">Mail Adresimi Onayla</a>
                        </div>";
            List<EmailAddress> tos = new List<EmailAddress>();
            tos.Add(new EmailAddress(user.Email));
            var emailResult = await EmailSenderService.SendEmail("Mail Onayı", html, tos);

            return new();

        }
    }
}

