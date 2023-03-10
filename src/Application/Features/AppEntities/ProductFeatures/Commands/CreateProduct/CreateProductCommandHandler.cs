using System;
using Application.Helpers;
using Application.Messaging;
using Application.Services;
using Domain.Entities;

namespace Application.Features.AppEntities.ProductFeatures.Commands.CreateProduct
{
    public class CreateProductCommandHandler : ICommandHandler<CreateProductCommand, CreateProductCommandResponse>
    {
        private readonly IProductService _productService;
        private readonly IProductStore _productStore;
        public CreateProductCommandHandler(IProductService productService, IProductStore productStore)
        {
            _productService = productService;
            _productStore = productStore;
        }

        public async Task<CreateProductCommandResponse> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            //$"/Users/alperalanyali/Desktop/ETicaret/ETicaretClient/src/assets/images/{fileName}";
            string filePath = "/Users/alperalanyali/Desktop/ETicaret/ETicaretClient/src/assets/images/";
            var stringFileName = FileService.FileSaveToServer(request.ImageUrl,filePath) ;

            var quantityTypeId = new Guid(request.QuantityTypeId);
            var imageUrl = $"{stringFileName}";
            var product = new Product(request.Name, request.Code, quantityTypeId, imageUrl,request.Description, request.Price);
            await _productService.Create(product, cancellationToken);

            var productStore = new ProductStore(product.Id.ToString(), request.StoreId, request.Price, false);
            await _productStore.CreateAsync(productStore, cancellationToken);
            
            return new(product.Id.ToString(), "Ürün başarılı şekilde sisteme eklenmiştir");
        }
    }
}

