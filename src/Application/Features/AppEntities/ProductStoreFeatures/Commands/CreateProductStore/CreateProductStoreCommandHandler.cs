using System;
using Application.Helpers;
using Application.Messaging;
using Application.Services;
using Domain.Entities;

namespace Application.Features.AppEntities.ProductStoreFeatures.Commands.CreateProductStore
{
	public class CreateProductStoreCommandHandler:ICommandHandler<CreateProductStoreCommand,CreateProductStoreCommandResponse>
	{
        private readonly IProductStore _productStore;

        public CreateProductStoreCommandHandler(IProductStore productStore)
        {
            _productStore = productStore;
        }

     

        public async Task<CreateProductStoreCommandResponse> Handle(CreateProductStoreCommand request, CancellationToken cancellationToken)
        {

            string filePath = "/Users/alperalanyali/Desktop/ETicaret/ETicaretClient/src/assets/images/";
            var stringFileName = FileService.FileSaveToServer(request.ImageUrl, filePath);

            var quantityTypeId = new Guid(request.QuantityTypeId);
            var imageUrl = $"{stringFileName}";
            var productStore = new ProductStore(request.Code, request.Name, request.Description, imageUrl,quantityTypeId, request.StoreId, request.Price,request.InStock) ;

            await _productStore.CreateAsync(productStore, cancellationToken);

            return new();
        }
    }
}

