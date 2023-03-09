using System;
using Domain.Entities;
using Domain.Repositories.AppEntities.IyzicoSettingRepository;
using Persistence.Context;
using Persistence.Repositories.GenericRepositories.AppDbContext;

namespace Persistence.Repositories.AppEntities.IyzicoSettingRepository
{
    public class IyzicoSettingQueryRepository : AppQueryRepository<IyzicoSetting>, IIyzicoSettingQueryRepository
    {
        public IyzicoSettingQueryRepository(AppDbContext context) : base(context)
        {
        }
    }
}

