using System;
using Application.Messaging;
using Application.Services;

namespace Application.Features.AppEntities.ProductStoreFeatures.Queries.GetProductStoreByCategoryId
{
	public class GetProductStoreByCategoryIdQueryHandler:IQueryHandler<GetProductStoreByCategoryIdQuery,GetProductStoreByCategoryIdQueryResponse>
	{
        private readonly IProductStore _productStore;
		public GetProductStoreByCategoryIdQueryHandler(IProductStore productStore)
		{
            _productStore = productStore;
		}

        public async Task<GetProductStoreByCategoryIdQueryResponse> Handle(GetProductStoreByCategoryIdQuery request, CancellationToken cancellationToken)
        {
            var productStores = await _productStore.GetProductStoresByCategoryId(request.CategoryId);

            return new(productStores.Count(), productStores);
        }
    }
}

