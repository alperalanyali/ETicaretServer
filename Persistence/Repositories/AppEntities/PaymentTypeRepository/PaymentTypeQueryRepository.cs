using System;
using Domain.Entities;
using Domain.Repositories.AppEntities.PaymentTypeRepository;
using Persistence.Context;
using Persistence.Repositories.GenericRepositories.AppDbContext;

namespace Persistence.Repositories.AppEntities.PaymentTypeRepository
{
    public class PaymentTypeQueryRepository : AppQueryRepository<PaymentType>, IPaymentTypeQueryRepository
    {
        public PaymentTypeQueryRepository(AppDbContext context) : base(context)
        {
        }
    }
}

