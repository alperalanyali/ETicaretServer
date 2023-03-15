using System;
using Application.Services;
using Domain.Dtos;
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

        public async Task<IList<Product>> GetAllProduct(int pageNumber,int pageSize)
        {
            return await _productQuery.GetAll().Include("QuantityType").Take(pageSize).Skip(pageNumber-1).ToListAsync();
        }
        public async Task<IList<Product>> GetAllProductWithCategories(int pageNumber, int pageSize)
        {
            var result =
                _productQuery
                .GetAll()                                          
                .Take(pageSize)
                .Skip(pageNumber - 1)
                ;
              
            //var newResult = result.
            return await result.ToListAsync();
        }


        public async Task<Product> GetById(string id)
        {
            return await _productQuery.GetWhere(p => p.Id == new Guid(id))/*.Include(p =>p.ProductCategories).ThenInclude(p => p.Category)*/.FirstOrDefaultAsync();
        }

        public async Task<bool> CheckExistProductByCodeAndName(string code, string name)
        {
            var result = false;
            var product = await _productQuery.GetWhere(p => p.Code == code && p.Name == name).FirstOrDefaultAsync();
            if (product != null)
            {
                result = true;
            }
            return result;
        }

        public async Task<IList<Product>> GetProductsByCategoryId(string categoryId)
        {
            //var products = await _productQuery.GetWhere(p => p.ProductCategories.Any(x => x.Category.Id == new Guid(categoryId))).Include(p => p.ProductCategories).ThenInclude(p => p.Category).ToListAsync();
            var products = new List<Product>();
            return products;
        }

        public async Task<IList<Product>> GetProductsByQuantityTypeId(string quantityTypeId)
        {
            return await _productQuery.GetWhere(p => p.QuantityTypeId == new Guid(quantityTypeId)).Include("QuantityTypes").ToListAsync();
        }

        public async Task Update(Product product, CancellationToken cancellationToken)
        {
            _productCommand.Update(product);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
        }

        public async Task<Product> GetProductByCodeAndName(string code, string name)
        {
            return await _productQuery.GetWhere(p => p.Code == code && p.Name == name).FirstOrDefaultAsync(); 
        }
    }
}

