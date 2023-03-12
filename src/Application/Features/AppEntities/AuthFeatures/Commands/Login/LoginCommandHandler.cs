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
            bool isSuccess = true;
            string message = " ";
            if (user == null) {                
                message = "Böyle bir kullanıcı yoktur";
                isSuccess = false;
            }
            
            var checkUser = await _authService.CheckPasswordAsync(user, request.Password);
            if (!checkUser) {
                message = "Şifreniz yanlış";
                isSuccess = false;
            }
            
            var response = new LoginCommandResponse(
                isSuccess:isSuccess,
                Message:message,
                Email:user.Email,
                UserId:user.Id,
                FullName:user.FullName,
                RoleId: user.RoleId.ToString(),
                StoreId: user.StoreId.ToString()
                );

            return response;
        }
    }
}

