using System;
using Application.Messaging;
using Domain.Entities.Identity;
using Microsoft.AspNetCore.Identity;

namespace Application.Features.AppEntities.AuthFeatures.Commands.UpdateUser
{
	public class UpdateUserCommandHandler:ICommandHandler<UpdateUserCommand,UpdateUserCommandResponse>
	{
		private readonly UserManager<AppUser> _userManager;
	
		public UpdateUserCommandHandler(UserManager<AppUser> userManager)
		{
			_userManager = userManager;
			
		}

        public async Task<UpdateUserCommandResponse> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {
			var user = await _userManager.FindByIdAsync(request.Id);
			user.StoreId = new Guid(request.StoreId);

			await _userManager.UpdateAsync(user);
			return new();
        }
    }
}

