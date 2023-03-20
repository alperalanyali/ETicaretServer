using System;
using Application.Services;
using Domain.Entities;
using Domain.Repositories.AppEntities.BasketRepository;
using Domain.UnitOfWork;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Services.AppEntities
{
    public class BasketService : IBasketService
    {
        private readonly IBasketCommandRepository _basketCommand;
        private readonly IBasketQueryRepository _basketQuery;
        private readonly IAppUnitOfWork _unitOfWork;

        public BasketService(IBasketCommandRepository basketCommandRepository, IBasketQueryRepository basketQueryRepository, IAppUnitOfWork appUnitOfWork)
        {
            _basketCommand = basketCommandRepository;
            _basketQuery = basketQueryRepository;
            _unitOfWork = appUnitOfWork;
        }
        public async Task CreateBasket(Basket basket, CancellationToken cancellationToken)
        {
            await _basketCommand.AddAsync(basket, cancellationToken);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
        }

        public async Task Delete(string id, CancellationToken cancellationToken)
        {
            await _basketCommand.RemoveById(id);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
        }

        public async Task<IList<Basket>> GetAllBasket()
        {
            return await _basketQuery.GetAll().ToListAsync();
        }

   

        public async Task<Basket> GetBasketIdByUserId(string userId)
        {
            var result = _basketQuery.GetWhere(p => p.UserId == new Guid(userId)).Include(p => p.BasketItems).ThenInclude(b => b.ProductStore).ThenInclude(p => p.QuantityType).OrderByDescending(p => p.CreatedDate).FirstOrDefaultAsync();
            return await result ; 
        }

        public async Task<Basket> GetById(string id)
        {
            var result = await _basketQuery.GetWhere(p => p.Id == new Guid(id))/*.Include(p => p.BasketItems).ThenInclude(b => b.ProductStore).ThenInclude(p => p.Product)*/.FirstOrDefaultAsync();
            return  result;
        }

        public async Task Update(Basket basket, CancellationToken cancellationToken)
        {
            _basketCommand.Update(basket);
            await _unitOfWork.SaveChangesAsync(cancellationToken);

        }
    }
}

