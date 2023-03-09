using System;
using Domain.Entities;

namespace Application.Services
{
	public interface IIyzicoSettingsService
	{
        Task UpdateAsync(IyzicoSetting ıyzicoSetting,CancellationToken cancellationToken);
        Task<IyzicoSetting> GetFirstAsync();
    }
}

