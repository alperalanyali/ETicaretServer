using System;
using Domain.Entities;

namespace Application.Services
{
	public interface IProductService
	{
		Task Create(Product product, CancellationToken cancellationToken);
		Task Update(Product product, CancellationToken cancellationToken);
		Task Delete(string id, CancellationToken cancellationToken);
		Task<IList<Product>> GetAllProduct(int pageNumber,int pageSize);
		Task<IList<Product>> GetAllProductWithCategories(int pageNumber, int pageSize);

        Task<Product> GetById(string id);
		Task<IList<Product>> GetProductsByCategoryId(string categoryId);
		Task<IList<Product>> GetProductsByQuantityTypeId(string quantityTypeId);
		Task<bool> CheckExistProductByCodeAndName(string code, string name);
		Task<Product> GetProductByCodeAndName(string code, string name);
	}
}

