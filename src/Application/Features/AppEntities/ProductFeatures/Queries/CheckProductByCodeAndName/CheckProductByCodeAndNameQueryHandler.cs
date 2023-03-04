using System;
using Application.Messaging;
using Application.Services;

namespace Application.Features.AppEntities.ProductFeatures.Queries.CheckProductByCodeAndName
{
	public class CheckProductByCodeAndNameQueryHandler:IQueryHandler<CheckProductByCodeAndNameQuery,CheckProductByCodeAndNameQueryResponse>
	{
        private readonly IProductService _productService;
		public CheckProductByCodeAndNameQueryHandler(IProductService productService)
		{
            _productService = productService;
		}

        public async Task<CheckProductByCodeAndNameQueryResponse> Handle(CheckProductByCodeAndNameQuery request, CancellationToken cancellationToken)
        {
            var result = "";
            var isExist = await _productService.CheckExistProductByCodeAndName(request.Code, request.Name);
            result = isExist ? "Böyle bir kayıt var" : " ";

            return new(isExist);
        }
    }
}

