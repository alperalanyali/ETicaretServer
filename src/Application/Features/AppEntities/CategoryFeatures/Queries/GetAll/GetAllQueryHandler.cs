using System;
using Application.Messaging;
using Application.Services;

namespace Application.Features.AppEntities.CategoryFeatures.Queries.GetAll
{
    public class GetAllQueryHandler : IQueryHandler<GetAllQuery, GetAllQueryResponse>
    {
        private readonly ICategoryService _categoryService;

        public GetAllQueryHandler(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public async Task<GetAllQueryResponse> Handle(GetAllQuery request, CancellationToken cancellationToken)
        {
            var results = await _categoryService.GetCategories("");
            return new(true, results.Count(), results);
        }
    }
}

