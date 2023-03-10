using System;
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
            var productStore = new ProductStore(request.ProductId,request.StoreId,request.Price,request.UseProductPrice);

            await _productStore.CreateAsync(productStore, cancellationToken);

            return new();
        }
    }
}

