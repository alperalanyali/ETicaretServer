using System;
using Application.Features.AppEntities.CategoryFeatures.Commands.CreateCategory;
using Domain.Entities;

namespace Application.Services
{
	public interface ICategoryService
	{
		Task CreateCategoryAsync(Category category, CancellationToken cancellationToken);
		Task<Category> GetById(string id);
		Task Delete(string id, CancellationToken cancellationToken);
		Task UpdateAsync(Category category, CancellationToken cancellationToken);
		Task<IList<Category>> GetCategories(string searchFor);


	}
}

