using System;
using Application.Messaging;
using Application.Services;
using Domain.Entities.Identity;
using Microsoft.AspNetCore.Identity;

namespace Application.Features.AppEntities.AuthFeatures.Commands.Login
{
    public class LoginCommandHandler : ICommandHandler<LoginCommand, LoginCommandResponse>
    {
        private readonly IAuthService _authService;
        private readonly RoleManager<AppRole> _roleManager;

        public LoginCommandHandler(IAuthService authService, RoleManager<AppRole> roleManager)
        {
            _authService = authService;
            _roleManager = roleManager;
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

            var role = await _roleManager.FindByIdAsync(user.RoleId.ToString());
            var response = new LoginCommandResponse(
                isSuccess:isSuccess,
                Message:message,
                Email:user.Email,
                UserId:user.Id,
                FullName:user.FullName,
                Role: role,
                StoreId: user.StoreId.ToString()
                );

            return response;
        }
    }
}

