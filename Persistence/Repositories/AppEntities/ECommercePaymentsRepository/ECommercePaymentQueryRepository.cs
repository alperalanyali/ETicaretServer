using System;
using Domain.Entities;
using Domain.Repositories.AppEntities.ECommercePayments;
using Persistence.Context;
using Persistence.Repositories.GenericRepositories.AppDbContext;

namespace Persistence.Repositories.AppEntities.ECommercePaymentsRepository
{
    public class ECommercePaymentQueryRepository : AppQueryRepository<ECommercePayment>, IECommercePaymentsQueryRepository
    {
        public ECommercePaymentQueryRepository(AppDbContext context) : base(context)
        {
        }
    }
}

