using System;
using Application.Messaging;
using Domain.Entities.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.AppEntities.UserFeatures.Queries.GetAllUser
{
	public class GetAllUserQueryHandler:IQueryHandler<GetAllUserQuery,GetAllUserQueryResponse>
	{
        private readonly UserManager<AppUser> _userManager;

        public GetAllUserQueryHandler(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<GetAllUserQueryResponse> Handle(GetAllUserQuery request, CancellationToken cancellationToken)
        {
            var users =await _userManager.Users.Include(p =>p.Role).ToListAsync();

            return new(users.Count(), users);
        }
    }
}

