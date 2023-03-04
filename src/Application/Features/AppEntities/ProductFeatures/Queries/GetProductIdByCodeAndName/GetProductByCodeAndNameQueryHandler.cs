using System;
using Application.Messaging;
using Application.Services;

namespace Application.Features.AppEntities.ProductFeatures.Queries.GetProductIdByCodeAndName
{
	public class GetProductByCodeAndNameQueryHandler:IQueryHandler<GetProductByCodeAndNameQuery,GetProductByCodeAndNameQueryResponse>
	{
		private readonly IProductService _productService;
		public GetProductByCodeAndNameQueryHandler(IProductService productService)
		{
			_productService = productService;
		}

        public async Task<GetProductByCodeAndNameQueryResponse> Handle(GetProductByCodeAndNameQuery request, CancellationToken cancellationToken)
        {
			var product = await _productService.GetProductByCodeAndName(request.Code, request.Name);
			return new(product);
        }
    }
}

