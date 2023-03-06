using System;
using Application.Messaging;
using Application.Services;
using Domain.Entities;

namespace Application.Features.AppEntities.CategoryFeatures.Commands.CreateCategory
{
	public class CreateCategoryCommandHandler:ICommandHandler<CreateCategoryCommand,CreateCategoryCommandResponse>
	{
		private readonly ICategoryService _categoryService;

        public CreateCategoryCommandHandler(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public async Task<CreateCategoryCommandResponse> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
        {
            var category = new Category(itemNo:request.ItemNo,name: request.Name, code: request.Code);
            await _categoryService.CreateCategoryAsync(category, cancellationToken);

            var response = new CreateCategoryCommandResponse(true, "Kategori başarılı şekilde olusturulmuştur", category);

            return response;
        }
    }
}

