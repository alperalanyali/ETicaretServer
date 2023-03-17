using System;
using Application.Services;
using Domain.Entities;
using Domain.Repositories.AppEntities.OrderRepository;
using Domain.UnitOfWork;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Services.AppEntities
{
    public class OrderService : IOrderService
    {
        private readonly IOrderCommandRepository    _orderCommand;
        private readonly IOrderQueryRepository      _orderQuery;
        private readonly IAppUnitOfWork _unitOfWork;

        public OrderService(IOrderCommandRepository orderCommandRepository, IOrderQueryRepository orderQueryRepository, IAppUnitOfWork appUnitOfWork)
        {
            _orderCommand = orderCommandRepository;
            _orderQuery = orderQueryRepository;
            _unitOfWork = appUnitOfWork;
        }

        public async Task Create(Order order, CancellationToken cancellationToken)
        {
            await _orderCommand.AddAsync(order, cancellationToken);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
        }

        public async Task Delete(string id, CancellationToken cancellationToken)
        {
            await _orderCommand.RemoveById(id);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
        }

        public async Task<IList<Order>> GetAllOrders()
        {
            return await _orderQuery.GetAll().ToListAsync();
        }

        public async Task<Order> GetById(string id)
        {
            return await _orderQuery.GetById(id, false);
        }

        public async Task<Order> GetLastOrderByUserId(Guid userId)
        {
            var result = await _orderQuery.GetWhere(p => p.UserId == userId).OrderByDescending(p => p.CreatedDate).FirstOrDefaultAsync();
            return result;
        }

        public async Task<IList<Order>> GetOrdersByUserId(string userId)
        {
            var results = await _orderQuery.GetWhere(p => p.UserId == new Guid(userId)).Include(oi => oi.OrderItems).ThenInclude(p => p.ProductStore).ThenInclude(p => p.QuantityType).Include(p=> p.Address).Include(p => p.PaymentType).OrderByDescending(p => p.CreatedDate).Include(p => p.Address).Include(p=>p.PaymentType).Include(p => p.OrderItems).ThenInclude(p => p.ProductStore).ToListAsync();

            return results;
        }

        public async Task Update(Order order, CancellationToken cancellationToken)
        {
            _orderCommand.Update(order);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
        }
        
       
    }
}

