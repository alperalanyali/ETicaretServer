using System;
using Application.Messaging;
using Domain.Entities.Identity;
using Microsoft.AspNetCore.Identity;

namespace Application.Features.AppEntities.RoleFeatures.Queries.GetRoleById
{
	public class GetRoleByIdQueryHandler:IQueryHandler<GetRoleByIdQuery,GetRoleByIdQueryResponse>
	{
        private readonly RoleManager<AppRole> _roleManager;
        public GetRoleByIdQueryHandler(RoleManager<AppRole> roleManager)
		{
            _roleManager = roleManager;
		}

        public async Task<GetRoleByIdQueryResponse> Handle(GetRoleByIdQuery request, CancellationToken cancellationToken)
        {
            var role = await _roleManager.FindByIdAsync(request.Id);

            return new(role);
        }
    }
}

