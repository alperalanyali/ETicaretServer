using System;
using Domain.Entities;
using Domain.Repositories.AppEntities.OrderItemRepository;
using Persistence.Context;
using Persistence.Repositories.GenericRepositories.AppDbContext;

namespace Persistence.Repositories.AppEntities.OrderItemRepository
{
    public class OrderItemCommandRepository : AppCommandRepository<OrderItem>, IOrderItemCommandRepository
    {
        public OrderItemCommandRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}

