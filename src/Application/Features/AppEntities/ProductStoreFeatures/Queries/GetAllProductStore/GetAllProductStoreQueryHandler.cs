using System;
using Application.Messaging;
using Application.Services;

namespace Application.Features.AppEntities.ProductStoreFeatures.Queries.GetAllProductStore
{
	public class GetAllProductStoreQueryHandler:IQueryHandler<GetAllProductStoreQuery,GetAllProductStoreQueryResponse>
	{
        private readonly IProductStore _productStoreService;

        public GetAllProductStoreQueryHandler(IProductStore productStore)
        {
            _productStoreService = productStore;
        }

        public async Task<GetAllProductStoreQueryResponse> Handle(GetAllProductStoreQuery request, CancellationToken cancellationToken)
        {
            var results = await _productStoreService.GetAll();

            return new(results.Count(), results);
        }
    }
}

