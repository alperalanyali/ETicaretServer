using System;
namespace Application.Features.AppEntities.IyzicoSettingFeatures.Commands.UpdateIyzicoSetting
{
	public sealed record UpdateIyzicoSettingCommandResponse(
		string Message = "Iyzico ayarları başarılı şekilde güncellenmiştir"
		);

}

