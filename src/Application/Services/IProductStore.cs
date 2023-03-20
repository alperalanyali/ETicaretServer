using System;
using Application.Features.AppEntities.ProductStoreFeatures.Queries.GetAllProductStore;
using Domain.Entities;

namespace Application.Services
{
	public interface IProductStore
	{
        Task<IList<ProductStore>> GetAll(GetAllProductStoreQuery request);
        Task<ProductStore> GetById(string id);
        Task CreateAsync(ProductStore productStore, CancellationToken cancellationToken);
        Task UpdateAsync(ProductStore productStore, CancellationToken cancellationToken);
        Task Delete(string id, CancellationToken cancellationToken);
        Task<IList<ProductStore>> GetProductStoresByCategoryId(string categoryId);
        Task<IList<ProductStore>> GetProductStoresByStoreId(string storeId);
    }
}

