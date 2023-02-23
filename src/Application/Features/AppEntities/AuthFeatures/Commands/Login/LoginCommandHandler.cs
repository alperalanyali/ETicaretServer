using System;
using Application.Messaging;
using Application.Services;

namespace Application.Features.AppEntities.AuthFeatures.Commands.Login
{
    public class LoginCommandHandler : ICommandHandler<LoginCommand, LoginCommandResponse>
    {
        private readonly IAuthService _authService;

        public LoginCommandHandler(IAuthService authService)
        {
            _authService = authService;
        }

        public async Task<LoginCommandResponse> Handle(LoginCommand request, CancellationToken cancellationToken)
        {
            var user = await _authService.GetByEmailOrUsernameAsync(request.EmailOrUsername);
            if (user == null)
                throw new Exception("Böyle bir kullanıcı yoktur");
            var checkUser = await _authService.CheckPasswordAsync(user, request.Password);
            if (!checkUser)
                throw new Exception("Şifreniz yanlış");
            var response = new LoginCommandResponse(
                Email:user.Email,
                UserId:user.Id,
                FullName:user.FullName
                );

            return response;
        }
    }
}

