using System;
using Application.Messaging;
using Application.Services;

namespace Application.Features.AppEntities.AuthFeatures.Commands.RefreshPassword
{
	public class RefreshPasswordCommandHandler:ICommandHandler<RefreshPasswordCommand,RefreshPasswordCommandResponse>
	{
        private readonly IAuthService _authService;

        public RefreshPasswordCommandHandler(IAuthService authService)
        {
            _authService = authService;
        }

        public async Task<RefreshPasswordCommandResponse> Handle(RefreshPasswordCommand request, CancellationToken cancellationToken)
        {
            await _authService.RefreshPassword(request.Id, request.Password);
            return new();
        }
    }
}

