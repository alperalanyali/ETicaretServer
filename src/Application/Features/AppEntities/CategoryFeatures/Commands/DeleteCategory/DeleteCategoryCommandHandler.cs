using System;
using Application.Messaging;
using Application.Services;

namespace Application.Features.AppEntities.CategoryFeatures.Commands.DeleteCategory
{
    public class DeleteCategoryCommandHandler : ICommandHandler<DeleteCategoryCommand, DeleteCategoryCommandResponse>
    {
        private readonly ICategoryService _categoryService;

        public DeleteCategoryCommandHandler(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public async Task<DeleteCategoryCommandResponse> Handle(DeleteCategoryCommand request, CancellationToken cancellationToken)
        {
            await _categoryService.Delete(request.Id, cancellationToken);
            return new();
        }
    }
}

