using System;
using Application.Messaging;
using Application.Services;
using Domain.Dtos;

namespace Application.Features.AppEntities.ProductFeatures.Queries.GetAllProducts
{
    public class GetAllProductsQueryHandler : IQueryHandler<GetAllProductsQuery, GetAllProductsQueryResponse>
    {
        private readonly IProductService _productService;
        private readonly IProductCategoryService _productCatService;

        public GetAllProductsQueryHandler(IProductService productService,IProductCategoryService productCategoryService)
        {
            _productService = productService;
            _productCatService = productCategoryService;
        }
        public async Task<GetAllProductsQueryResponse> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
        {
            var products = await _productService.GetAllProduct(request.PageNumber,request.PageSize);
            var productDtos = new List<ProductDto>();
            foreach (var product in products)
            {
                ProductDto productDto = new ProductDto();
                var categories = await _productCatService.GetProductCategoryByProductId(product.Id);
                productDto.Id = product.Id;
                productDto.Code = product.Code;
                productDto.Name = product.Name;
                productDto.Price = product.Price;
                productDto.ImageUrl = product.ImageUrl;
                productDto.Description = product.Description;
                productDto.Categories = new List<CategoryDto>();
                foreach (var category in categories)
                {
                    CategoryDto categoryDto = new CategoryDto(category.Category.Id, category.Category.Code, category.Category.Name);
  

                    productDto.Categories.Add(categoryDto);
                }
              
               

                productDtos.Add(productDto);


            }
            return new(true, products.Count(), productDtos);
        }
    }
}

