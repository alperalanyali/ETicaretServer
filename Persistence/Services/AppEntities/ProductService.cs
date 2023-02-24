using System;
using Application.Services;
using Domain.Entities;
using Domain.Repositories.AppEntities.ProductRepository;
using Domain.UnitOfWork;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Services.AppEntities
{
    public class ProductService : IProductService
    {
        private readonly IProductCommandRepository _productCommand;
        private readonly IProductQueryRepository _productQuery;
        private readonly IAppUnitOfWork _unitOfWork;

        public ProductService(IProductCommandRepository productCommandRepository, IProductQueryRepository productQueryRepository, IAppUnitOfWork unitOfWork)
        {
            _productCommand = productCommandRepository;
            _productQuery = productQueryRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task Create(Product product, CancellationToken cancellationToken)
        {
            await _productCommand.AddAsync(product, cancellationToken);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
        }

        public async Task Delete(string id, CancellationToken cancellationToken)
        {
            await _productCommand.RemoveById(id);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
        }

        public async Task<IList<Product>> GetAllProduct()
        {
            return await _productQuery.GetAll().Include("QantityTypes").ToListAsync();
        }

        public async Task<Product> GetById(string id)
        {
            return await _productQuery.GetById(id, false);
        }

        public Task<IList<Product>> GetProductsByCategoryId(string categoryId)
        {
            throw new NotImplementedException();
        }

        public async Task<IList<Product>> GetProductsByQuantityTypeId(string quantityTypeId)
        {
            return await _productQuery.GetWhere(p => p.QuantityTypeId == new Guid(quantityTypeId)).ToListAsync();
        }

        public async Task Update(Product product, CancellationToken cancellationToken)
        {
            _productCommand.Update(product);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
        }
    }
}

