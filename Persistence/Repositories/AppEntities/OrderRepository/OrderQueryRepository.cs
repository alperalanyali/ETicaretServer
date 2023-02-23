using System;
using Domain.Entities;
using Domain.Repositories.AppEntities.OrderRepository;
using Persistence.Context;
using Persistence.Repositories.GenericRepositories.AppDbContext;

namespace Persistence.Repositories.AppEntities.OrderRepository
{
    public class OrderQueryRepository : AppQueryRepository<Order>, IOrderQueryRepository
    {
        public OrderQueryRepository(AppDbContext context) : base(context)
        {
        }
    }
}

