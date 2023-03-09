using System;
using Application.Messaging;
using Domain.Entities;

namespace Application.Features.AppEntities.IyzicoSettingFeatures.Commands.UpdateIyzicoSetting
{
	public sealed record UpdateIyzicoSettingCommand(
		IyzicoSetting IyzicoSetting 
		):ICommand<UpdateIyzicoSettingCommandResponse>;

}

