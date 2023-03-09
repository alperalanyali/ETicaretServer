using System;
using Domain.Entities;

namespace Application.Features.AppEntities.IyzicoSettingFeatures.Queries.GetFirstIyzicoSetting
{
	public sealed record GetFirstIyzicoSettingQueryResponse(
		IyzicoSetting IyzicoSetting
		);
	
}

