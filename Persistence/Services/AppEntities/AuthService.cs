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
                Id = Guid.NewGuid(),
                UserName = request.Username,
                Email = request.Email,
                FullName = request.FullName,
                //StoreId = new Guid(request.StoreId),
                RoleId = new Guid(request.RoleId),
                RefreshToken = "112313"

            }, request.Password) ;

            return user;
        }

        public async Task<AppUser> GetByEmailOrUsernameAsync(string emailOrUsername)
        {
            var user = await _userManager.Users.Where(u => u.Email == emailOrUsername || u.UserName == emailOrUsername).FirstOrDefaultAsync();
            return user;
        }

        public async Task<AppUser> GetById(string Id)
        {
            var user = await _userManager.FindByIdAsync(Id);
            return user;
 
        }

        public async Task RefreshPassword(string id, string password)
        {
            var user = await _userManager.FindByIdAsync(id);
            user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, password);
            var result = await _userManager.UpdateAsync(user);
        }

        public async Task Update(AppUser user, CancellationToken cancellationToken)
        {
            await _userManager.UpdateAsync(user);
        }
    }
}

