using System;
using Application.Services;
using Domain.Entities;
using Domain.Repositories.AppEntities.IyzicoSettingRepository;
using Domain.UnitOfWork;

namespace Persistence.Services.AppEntities
{
    public class IyzicoSettingService : IIyzicoSettingsService
    {
        private readonly IIyzicoSettingCommandRepository _iyzicoCommand;
        private readonly IIyzicoSettingQueryRepository _iyzicoQuery;
        private readonly IAppUnitOfWork _unitOfWork;


        public IyzicoSettingService(IIyzicoSettingCommandRepository iyzicoSettingCommandRepository, IIyzicoSettingQueryRepository iyzicoSettingQueryRepository, IAppUnitOfWork appUnitOfWork)
        {
            _iyzicoCommand = iyzicoSettingCommandRepository;
            _iyzicoQuery = iyzicoSettingQueryRepository;
            _unitOfWork = appUnitOfWork;
        }

        public async Task UpdateAsync(IyzicoSetting ıyzicoSetting,CancellationToken cancellationToken)
        {
            _iyzicoCommand.Update(ıyzicoSetting);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
        }

        Task<IyzicoSetting> IIyzicoSettingsService.GetFirstAsync()
        {
            var result = _iyzicoQuery.GetFirst(false);
            return result;
        }
    }
}

