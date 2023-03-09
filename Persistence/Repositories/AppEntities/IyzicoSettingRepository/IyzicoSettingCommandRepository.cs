using System;
using Application.Services;
using Domain.Entities;
using Persistence.Repositories.GenericRepositories.AppDbContext;
using Persistence.Context;
using Domain.Repositories.AppEntities.IyzicoSettingRepository;

namespace Persistence.Repositories.AppEntities.IyzicoSettingRepository
{
    public class IyzicoSettingCommandRepository : AppCommandRepository<IyzicoSetting>, IIyzicoSettingCommandRepository
    {
        public IyzicoSettingCommandRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}

