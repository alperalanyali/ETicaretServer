using System;
using Application.Messaging;
using Application.Services;

namespace Application.Features.AppEntities.IyzicoSettingFeatures.Commands.UpdateIyzicoSetting
{
	public class UpdateIyzicoSettingCommandHandler:ICommandHandler<UpdateIyzicoSettingCommand,UpdateIyzicoSettingCommandResponse>
	{
        private readonly IIyzicoSettingsService _iyzcioService;
        public UpdateIyzicoSettingCommandHandler(IIyzicoSettingsService ıyzicoSettingsService)
        {
            _iyzcioService = ıyzicoSettingsService;
        }

        public async Task<UpdateIyzicoSettingCommandResponse> Handle(UpdateIyzicoSettingCommand request, CancellationToken cancellationToken)
        {
            await _iyzcioService.UpdateAsync(request.IyzicoSetting, cancellationToken);
            return new();
        }
    }
}

