using System;
using Application.Messaging;
using Application.Services;

namespace Application.Features.AppEntities.AuthFeatures.Commands.CreateUser
{
    public class CreateUserCommandHandler : ICommandHandler<CreateUserCommand, CreateUserCommandResponse>
    {
        private IAuthService _authService;

        public CreateUserCommandHandler(IAuthService authService)
        {
            _authService = authService;
        }

        public async Task<CreateUserCommandResponse> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var result = await _authService.CreateUser(request, cancellationToken);
            var response = new CreateUserCommandResponse();
            if (result.Succeeded)
            {
                return new(true, "Kullanıcı başarılı şekilde oluşturuldu.");
            }else
            {
                return new(false, "Kullanıcı oluşturulmadı");
            }
            
        }
    }
}

