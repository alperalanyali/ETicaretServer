using System;
using Application.Features.AppEntities.AuthFeatures.Commands.CreateUser;
using Domain.Entities.Identity;
using Microsoft.AspNetCore.Identity;

namespace Application.Services
{
	public interface IAuthService
	{
		Task<IdentityResult> CreateUser(CreateUserCommand request, CancellationToken cancellationToken);
        Task<AppUser> GetByEmailOrUsernameAsync(string emailOrUsername);
        Task<bool> CheckPasswordAsync(AppUser user, string password);
        Task Update(AppUser user, CancellationToken cancellationToken);
        Task<AppUser> GetById(string Id);
        Task RefreshPassword(string id, string password);
    }
}

