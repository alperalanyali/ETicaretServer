using System;
using Application.Features.AppEntities.AuthFeatures.Commands.CreateUser;
using Application.Services;
using Domain.Entities.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Services.AppEntities
{
    public class AuthService : IAuthService
    {
        private readonly UserManager<AppUser> _userManager;
        public AuthService(UserManager<AppUser>  userManager)
        {
            _userManager = userManager;
        }

        public async Task<bool> CheckPasswordAsync(AppUser user, string password)
        {
            var result = await _userManager.CheckPasswordAsync(user, password);
            return result;
        }

        public async Task<IdentityResult> CreateUser(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var user = await _userManager.CreateAsync(new AppUser()
            {
                UserName = request.Username,
                Email = request.Email,
                FullName = request.FullName,
                Id = Guid.NewGuid()                

            }, request.Password);

            return user;
        }

        public async Task<AppUser> GetByEmailOrUsernameAsync(string emailOrUsername)
        {
            var user = await _userManager.Users.Where(u => u.Email == emailOrUsername || u.UserName == emailOrUsername).FirstOrDefaultAsync();
            return user;
        }
    }
}

