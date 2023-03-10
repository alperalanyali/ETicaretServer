using System;
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

        public async Task<IList<ProductStore>> GetAll()
        {
            var results = await _query.GetAll().Include(p=>p.Product).ThenInclude(p => p.ProductCategories).ThenInclude(p => p.Category).Include(p => p.Store).Include(p=>p.Product).ThenInclude(p => p.QuantityType).ToListAsync();

            return results;
        }

        public async Task<ProductStore> GetById(string id)
        {
            return await _query.GetById(id);
        }

        public async Task<IList<ProductStore>> GetProductStoresByCategoryId(string categoryId)
        {
            var results = await _query.GetWhere(p => p.Product.ProductCategories.Any(p => p.CategoryId == new Guid(categoryId))).Include(p => p.Product).ThenInclude(p => p.ProductCategories).Include(p=> p.Store).Include(p =>p.Product).ThenInclude(p =>p.ProductCategories).ThenInclude(p => p.Category).ToListAsync();

            return results;
        }

        public async Task UpdateAsync(ProductStore productStore, CancellationToken cancellationToken)
        {
            _command.Update(productStore);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
        }
    }
}

