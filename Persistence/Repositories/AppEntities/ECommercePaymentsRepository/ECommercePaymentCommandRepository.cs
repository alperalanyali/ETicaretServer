using System;
using Domain.Entities;
using Domain.Repositories.AppEntities.ECommercePayments;
using Persistence.Context;
using Persistence.Repositories.GenericRepositories.AppDbContext;

namespace Persistence.Repositories.AppEntities.ECommercePaymentsRepository
{
    public class ECommercePaymentCommandRepository : AppCommandRepository<ECommercePayment>, IECommercePaymentsCommandRepository
    {
        public ECommercePaymentCommandRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}

