using System;
using Application.Features.AppEntities.CategoryFeatures.Commands.CreateCategory;
using Application.Services;
using Domain.Entities;
using Domain.Repositories.AppEntities.CategoryRepository;
using Domain.UnitOfWork;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Services.AppEntities
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryCommandRepository _categoryCommand;
        private readonly ICategoryQueryRepository _categoryQuery;
        private readonly IAppUnitOfWork _unitOfWork;
        public CategoryService(ICategoryCommandRepository categoryCommand,ICategoryQueryRepository categoryQueryRepository,IAppUnitOfWork unitOfWork)
        {
            _categoryCommand = categoryCommand;
            _categoryQuery = categoryQueryRepository;
            _unitOfWork = unitOfWork;
        }

    

        async Task ICategoryService.CreateCategoryAsync(Category category, CancellationToken cancellationToken)
        {
            await _categoryCommand.AddAsync(category, cancellationToken);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
        }


        async Task ICategoryService.Delete(string id, CancellationToken cancellationToken)
        {
            await _categoryCommand.RemoveById(id);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
        }

        Task<Category> ICategoryService.GetById(string id)
        {
            return _categoryQuery.GetById(id, false);
        }

 

        async Task<IList<Category>> ICategoryService.GetCategories(string searchFor)
        {
            return await _categoryQuery.GetAll().ToListAsync();
        }


        async Task ICategoryService.UpdateAsync(Category category, CancellationToken cancellationToken)
        {
            _categoryCommand.Update(category);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
        }
    }
}

