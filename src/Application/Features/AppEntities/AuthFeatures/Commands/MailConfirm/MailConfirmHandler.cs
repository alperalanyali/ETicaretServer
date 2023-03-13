using System;
using Application.Messaging;
using Application.Services;

namespace Application.Features.AppEntities.AuthFeatures.Commands.MailConfirm
{
    public class MailConfirmHandler : ICommandHandler<MailConfirmCommand, MailConfirmResponse>
    {
        private readonly IAuthService _authService;

        public MailConfirmHandler(IAuthService authService)
        {
            _authService = authService;
        }

        public async Task<MailConfirmResponse> Handle(MailConfirmCommand request, CancellationToken cancellationToken)
        {
            var user = await _authService.GetUserByCode(request.Code);

            if (user == null)
                return new("Kullanıcı bulunamadı");
            else
            {
                if(user.IsMailConfirmed)
                    return new("Kullanıcı maili zaten onaylı!");                                
            }
            user.IsMailConfirmed = true;

            await _authService.Update(user,cancellationToken);

            return new("Mail adresiniz başarıyla onaylandı!");
        }
    }
}

