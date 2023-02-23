using System;
using Application.Messaging;
using Application.Services;

namespace Application.Features.AppEntities.ProductFeatures.Commands.DeleteProduct
{
    public class DeleteProductCommandHandler : ICommandHandler<DeleteProductCommand, DeleteProductCommandResponse>
    {
        private readonly IProductService _productService;
        public DeleteProductCommandHandler(IProductService productService)
        {
            _productService = productService;
        }
        public async Task<DeleteProductCommandResponse> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
        {
            await _productService.Delete(request.Id, cancellationToken);
            return new();
        }
    }
}

