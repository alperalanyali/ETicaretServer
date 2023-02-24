using System;
using Application.Services;
using Domain.Entities;
using Domain.Repositories.AppEntities.ProductCategoryRepository;
using Domain.UnitOfWork;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Services.AppEntities
{
    public class ProductCategoryService : IProductCategoryService
    {
        private readonly IProductCategoryCommandRepository _productCategoryCommand;
        private readonly IProductCategoryQueryRepository _productCategoryQuery;
        private readonly IAppUnitOfWork _unitOfWork;
        public ProductCategoryService(IProductCategoryCommandRepository productCategoryCommandRepository, IProductCategoryQueryRepository productCategoryQueryRepository, IAppUnitOfWork appUnitOfWork)
        {
            _productCategoryCommand = productCategoryCommandRepository;
            _productCategoryQuery = productCategoryQueryRepository;
            _unitOfWork = appUnitOfWork;
        }

        public async Task CreateProductCategory(ProductCategory productCategory, CancellationToken cancellationToken)
        {
            await _productCategoryCommand.AddAsync(productCategory, cancellationToken);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
        }

        public async Task DeleteProductCategory(string id, CancellationToken cancellationToken)
        {
            await _productCategoryCommand.RemoveById(id);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
        }

        public async Task<IList<ProductCategory>> GetAllProductCategory()
        {
            return await _productCategoryQuery.GetAll().Include("Products").Include("Categories").ToListAsync();
        }

        public async Task<ProductCategory> GetById(string id)
        {
            return await _productCategoryQuery.GetById(id, false);
        }

        public async Task<IList<ProductCategory>> GetProductCategoryByCategoryId(Guid categoryId)
        {
            return await _productCategoryQuery.GetWhere(p => p.CategoryId == categoryId).Include("Products").Include("Categories").ToListAsync();
        }

        public async Task<IList<ProductCategory>> GetProductCategoryByProductId(Guid productId)
        {
            return await _productCategoryQuery.GetWhere(p => p.ProductId == productId).Include("Products").Include("Categories").ToListAsync();
        }

        public async Task UpdateProductCategory(ProductCategory productCategory, CancellationToken cancellationToken)
        {
            _productCategoryCommand.Update(productCategory);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
        }
    }
}

