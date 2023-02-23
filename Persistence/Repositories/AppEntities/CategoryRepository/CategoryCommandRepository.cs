using System;
using Domain.Entities;
using Domain.Repositories.AppEntities.CategoryRepository;
using Persistence.Context;
using Persistence.Repositories.GenericRepositories.AppDbContext;

namespace Persistence.Repositories.AppEntities.CategoryRepository
{
    public class CategoryCommandRepository : AppCommandRepository<Category>, ICategoryCommandRepository
    {
        public CategoryCommandRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}

