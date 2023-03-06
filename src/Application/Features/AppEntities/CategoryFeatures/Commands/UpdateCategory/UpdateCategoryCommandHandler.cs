using System;
using Application.Messaging;
using Application.Services;

namespace Application.Features.AppEntities.CategoryFeatures.Commands.UpdateCategory
{
    public class UpdateCategoryCommandHandler : ICommandHandler<UpdateCategoryCommand, UpdateCategoryCommandResponse>
    {
        private readonly ICategoryService _categoryService;

        public UpdateCategoryCommandHandler(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public async Task<UpdateCategoryCommandResponse> Handle(UpdateCategoryCommand request, CancellationToken cancellationToken)
        {
            var category = await _categoryService.GetById(request.Id);
            category.ItemNo = request.ItemNo;
            category.Name = request.Name;
            category.Code = request.Code;
            category.IsActive = request.IsActive;
            await _categoryService.UpdateAsync(category, cancellationToken);
            var response = new UpdateCategoryCommandResponse(true);
            return response;

        }
    }
}

