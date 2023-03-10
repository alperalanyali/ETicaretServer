using System;
using Application.Messaging;
using Application.Services;

namespace Application.Features.AppEntities.ProductStoreFeatures.Commands.DeleteProductStore
{
	public class DeleteProductStoreCommandHandler:ICommandHandler<DeleteProductStoreCommand,DeleteProductStoreCommandResponse>
	{
        private readonly IProductStore _productStoreService;
        public DeleteProductStoreCommandHandler(IProductStore productStore)
        {
            _productStoreService = productStore;
        }

        public async Task<DeleteProductStoreCommandResponse> Handle(DeleteProductStoreCommand request, CancellationToken cancellationToken)
        {
            await _productStoreService.Delete(request.Id, cancellationToken);


            return new();
        }
    }
}

