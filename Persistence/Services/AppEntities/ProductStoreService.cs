using System;
using Application.Features.AppEntities.ProductStoreFeatures.Queries.GetAllProductStore;
using Application.Services;
using Domain.Entities;
using Domain.Repositories.AppEntities.ProductStoreRepository;
using Domain.UnitOfWork;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Services.AppEntities
{
	public class ProductStoreService: IProductStore
    {
        private readonly IProductStoreCommandRepository _command;
        private readonly IProductStoreQueryRepository _query;
        private readonly IAppUnitOfWork _unitOfWork;
        public ProductStoreService(IProductStoreCommandRepository productStoreCommandRepository, IProductStoreQueryRepository productStoreQueryRepository, IAppUnitOfWork appUnitOfWork)
        {
            _command = productStoreCommandRepository;
            _query = productStoreQueryRepository;
            _unitOfWork = appUnitOfWork;
        }


        public async Task CreateAsync(ProductStore productStore, CancellationToken cancellationToken)
        {
            await _command.AddAsync(productStore, cancellationToken);
            await _unitOfWork.SaveChangesAsync(cancellationToken);

        }

        public async Task Delete(string id, CancellationToken cancellationToken)
        {
            _command.RemoveById(id);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
        }

        public async Task<IList<ProductStore>> GetAll(GetAllProductStoreQuery request)
        {
            var results = await _query.GetWhere(p => p.Name.ToLower().Contains(request.Search.ToLower()) || p.Description.ToLower().Contains(request.Search.ToLower()) || p.Store.StoreName.ToLower().Contains(request.Search.ToLower()) || p.ProductCategories.Any(pc => pc.Category.Name.ToLower().Contains(request.Search.ToLower()))).Include(p => p.Store).Include(p => p.QuantityType).Include(p=> p.ProductCategories).ThenInclude(p => p.Category).Skip((request.PagaNumber - 1)*request.PagaNumber).Take(request.PageSize).ToListAsync();

            return results;
        }

        public async Task<ProductStore> GetById(string id)
        {
            return await _query.GetById(id);
        }

        public async Task<IList<ProductStore>> GetProductStoresByCategoryId(string categoryId)
        {

            var results = await _query.GetWhere(p => p.ProductCategories.Any(p => p.CategoryId == new Guid(categoryId))).Include(p => p.Store).ToListAsync();
            
            return results;
        }

        public async Task<IList<ProductStore>> GetProductStoresByStoreId(string storeId)
        {
            var results = await _query.GetWhere(p => p.StoreId == new Guid(storeId)).ToListAsync();

            return results;
        }

        public async Task UpdateAsync(ProductStore productStore, CancellationToken cancellationToken)
        {
            _command.Update(productStore);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
        }
    }
}

