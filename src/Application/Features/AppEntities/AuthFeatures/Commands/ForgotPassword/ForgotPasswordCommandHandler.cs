using System;
using Application.Messaging;
using Application.Services;
using Infrastructure.Services;
using SendGrid.Helpers.Mail;

namespace Application.Features.AppEntities.AuthFeatures.Commands.ForgotPassword
{
	public class ForgotPasswordCommandHandler:ICommandHandler<ForgotPasswordCommand,ForgotPasswordCommandResponse>
	{
        private readonly IAuthService _authService;

        public ForgotPasswordCommandHandler(IAuthService authService)
        {
            _authService = authService;
        }

        public async Task<ForgotPasswordCommandResponse> Handle(ForgotPasswordCommand request, CancellationToken cancellationToken)
        {
         
            var user = await _authService.GetByEmailOrUsernameAsync(request.emailOrUsername);
            if (user == null)
            {
                return new("Böyle bir kullanıcı bulunamadı");
            }

            Random random = new Random();
            int result = random.Next(1000, 10000);

            user.IsForgotPasswordCodeActive = true;
            user.ForgotPasswordCode = result.ToString();

            await _authService.Update(user,cancellationToken);
            string html = $@"
              <div class=""container text-center"">
                    <h1>Şifrenizi Yenilemek için</h1>
                    <p>Aşağıdaki kodu size açılan sayfada ilgili alana girerek şifrenizi yenileyebilirsiniz! Eğer sayfayı kapattıysanız ya da açılmadıysa aşağıdaki <strong>'Sayfaya Git'</strong> linkini tıklayarak sayfaya ulaşabilirsiniz!</p>
                    <hr>
                    <h1>Kod: {user.ForgotPasswordCode}</h1>
                    <a href='http://localhost:4200/forgotPassword/" + user.Id+"/"+user.ForgotPasswordCode+@"'>Sayfaya Git</a>
                    </div>
                ";
            List<EmailAddress> tos= new List<EmailAddress>();
            tos.Add(new EmailAddress(user.Email));
            var emailResult = await EmailSenderService.SendEmail("Şifremi Unuttum", html, tos);

            return new("Lütfen epostanızı kontrol ediniz");
        }
    }
}

