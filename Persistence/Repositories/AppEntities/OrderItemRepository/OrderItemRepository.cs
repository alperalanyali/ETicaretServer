using System;
using Domain.Entities;
using Domain.Repositories.AppEntities.OrderItemRepository;
using Persistence.Context;
using Persistence.Repositories.GenericRepositories.AppDbContext;

namespace Persistence.Repositories.AppEntities.OrderItemRepository
{
    public class OrderItemRepository : AppQueryRepository<OrderItem>, IOrderItemQueryRepository
    {
        public OrderItemRepository(AppDbContext context) : base(context)
        {
        }
    }
}

