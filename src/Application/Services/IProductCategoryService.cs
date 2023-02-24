using System;
using Domain.Entities;

namespace Application.Services
{
	public interface IProductCategoryService
	{
		Task CreateProductCategory(ProductCategory productCategory, CancellationToken cancellationToken);
		Task UpdateProductCategory(ProductCategory productCategory, CancellationToken cancellationToken);
		Task DeleteProductCategory(string id, CancellationToken cancellationToken);
		Task<IList<ProductCategory>> GetAllProductCategory();
		Task<IList<ProductCategory>> GetProductCategoryByProductId(Guid productId);
		Task<IList<ProductCategory>> GetProductCategoryByCategoryId(Guid categoryId);
		Task<ProductCategory> GetById(string id);
	}
}

