using System;
using Application.Services;
using Domain.Entities;
using Domain.Repositories.AppEntities.BasketItemRepository;
using Domain.UnitOfWork;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Services.AppEntities
{
    public class BasketItemService : IBasketItemService
    {
        private readonly IBasketItemCommandRepository _basketItemCommand;
        private readonly IBasketItemQueryRepository _basketItemQuery;
        private readonly IAppUnitOfWork _unitOfWork;

        public BasketItemService(IBasketItemCommandRepository basketItemCommandRepository, IBasketItemQueryRepository basketItemQueryRepository, IAppUnitOfWork unitOfWork)
        {
            _basketItemCommand = basketItemCommandRepository;
            _basketItemQuery = basketItemQueryRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task Create(BasketItem basketItem, CancellationToken cancellationToken)
        {
            await _basketItemCommand.AddAsync(basketItem, cancellationToken);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
        }

        public async Task Delete(string id,CancellationToken cancellationToken)
        {
            await _basketItemCommand.RemoveById(id);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
        }

        public async Task DeleteBasketItemByBasketId(IList<BasketItem> basketItems,CancellationToken cancellationToken)
        {
 
             _basketItemCommand.RemoveRange(basketItems);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
            
        }

        public async Task<IList<BasketItem>> GetAllBasketItem()
        {
            return await _basketItemQuery.GetAll().ToListAsync();
        }

        public async Task<IList<BasketItem>> GetBasketItemByBasketId(string basketId)
        {
            return await _basketItemQuery.GetWhere(p => p.BasketId == new Guid(basketId)).Include(p => p.ProductStore).ThenInclude(p => p.Product).ToListAsync();
        }

        public async Task<BasketItem> GetById(string id)
        {
            return await _basketItemQuery.GetById(id, false);
        }

        public async Task Update(BasketItem basketItem, CancellationToken cancellationToken)
        {
            _basketItemCommand.Update(basketItem);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
        }
    }
}

