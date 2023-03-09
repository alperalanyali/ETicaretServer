using System;
using Application.Messaging;
using Application.Services;

namespace Application.Features.AppEntities.IyzicoSettingFeatures.Queries.GetFirstIyzicoSetting
{
    public class GetFirstIyzicoSettingQueryHandler : IQueryHandler<GetFirstIyzicoSettingQuery, GetFirstIyzicoSettingQueryResponse>
    {
        private readonly IIyzicoSettingsService _iyzicoSettingsService;

        public GetFirstIyzicoSettingQueryHandler(IIyzicoSettingsService iyzicoSettingsService)
        {
            _iyzicoSettingsService = iyzicoSettingsService;
        }

        public async Task<GetFirstIyzicoSettingQueryResponse> Handle(GetFirstIyzicoSettingQuery request, CancellationToken cancellationToken)
        {
            var result = await _iyzicoSettingsService.GetFirstAsync();

            return new(result);
        }
    }
}

