using System;
using Application.Messaging;
using Domain.Entities.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.AppEntities.RoleFeatures.Queries.GetAllRole
{
    public class GetAllRoleQueryHandler : IQueryHandler<GetAllRoleQuery, GetAllRoleQueryResponse>
    {
        private readonly RoleManager<AppRole> _roleManager;
        public GetAllRoleQueryHandler(RoleManager<AppRole> roleManager)
        {
            _roleManager = roleManager;
        }
        public async Task<GetAllRoleQueryResponse> Handle(GetAllRoleQuery request, CancellationToken cancellationToken)
        {
            var roles = await _roleManager.Roles.ToListAsync();

            return new(roles.Count(), roles);
        }
    }
}

