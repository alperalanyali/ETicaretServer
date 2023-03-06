using System;
using Application.Messaging;
using Domain.Entities.Identity;
using Microsoft.AspNetCore.Identity;

namespace Application.Features.AppEntities.AuthFeatures.Queries.GetUserById
{
    public class GetUserByIdQueryHandler : IQueryHandler<GetUserByIdQuery, GetUserByIdQueryResponse>
    {
        private readonly UserManager<AppUser> _userManager;
        public GetUserByIdQueryHandler(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<GetUserByIdQueryResponse> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
        {
            var user = await _userManager.FindByIdAsync(request.UserId);

            return new(user);
        }
    }
}

