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

        public CreateProductCommandHandler(IProductService productService)
        {
            _productService = productService;
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
            return new();
        }
    }
}

