using System;
using Application.Messaging;
using Application.Services;

namespace Application.Features.AppEntities.ProductFeatures.Commands.UpdateProduct
{
    public class UpdateProductCommandHandler : ICommandHandler<UpdateProductCommand, UpdateProductCommandResponse>
    {
        private readonly IProductService _productService;
        public UpdateProductCommandHandler(IProductService productService)
        {
            _productService = productService;
        }
        public async Task<UpdateProductCommandResponse> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            var product = await _productService.GetById(request.Id);
            product.Name = request.Name;
            product.Code = request.Code;
            product.Description = request.Description;
            product.QuantityTypeId = new Guid(request.QuantityTypeId);
            product.Price = request.Price;
            //product.ImageUrl = request.ImageUrl;

            await _productService.Update(product, cancellationToken);
            return new();
        }
    }
}

