using System;
using Application.Messaging;
using Application.Services;

namespace Application.Features.AppEntities.StoreFeatures.Queries.GetAll
{
	public class GetAllStoreQueryHandler:IQueryHandler<GetAllStoreQuery,GetAllStoreQuerResponse>
	{
        private readonly IStoreService _storeService;

		public GetAllStoreQueryHandler(IStoreService storeService)
		{
            _storeService = storeService;
		}

        public async Task<GetAllStoreQuerResponse> Handle(GetAllStoreQuery request, CancellationToken cancellationToken)
        {
            var results = await _storeService.GetAll();

            return new(results.Count(), results);
        }
    }
}

