using System;
using Application.Services;
using Domain.Entities;
using Domain.Repositories.AppEntities.OrderItemRepository;
using Domain.UnitOfWork;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Services.AppEntities
{
    public class OrderItemService : IOrderItemService
    {
        private readonly IOrderItemCommandRepository _orderItemCommand;
        private readonly IOrderItemQueryRepository _orderItemQuery;
        private readonly IAppUnitOfWork _unitOfWork;

        public OrderItemService(IOrderItemCommandRepository orderItemCommandRepository, IOrderItemQueryRepository orderItemQueryRepository, IAppUnitOfWork unitOfWork)
        {
            _orderItemCommand = orderItemCommandRepository;
            _orderItemQuery = orderItemQueryRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task Create(OrderItem orderItem, CancellationToken cancellationToken)
        {
            await _orderItemCommand.AddAsync(orderItem, cancellationToken);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
        }

        public async Task Delete(string id, CancellationToken cancellationToken)
        {
            await _orderItemCommand.RemoveById(id);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
        }

        public async Task<IList<OrderItem>> GetAllOrderItems()
        {
            return await _orderItemQuery.GetAll().ToListAsync();
        }

        public async Task<OrderItem> GetById(string id)
        {
            return await _orderItemQuery.GetById(id, false);
        }

        public async Task<IList<OrderItem>> GetOrderItemByOrderId(string orderId)
        {
            return await _orderItemQuery.GetWhere(p => p.OrderId == new Guid(orderId)).ToListAsync();
        }

        public async Task Update(OrderItem orderItem, CancellationToken cancellationToken)
        {
            _orderItemCommand.Update(orderItem);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
        }
    }
}

