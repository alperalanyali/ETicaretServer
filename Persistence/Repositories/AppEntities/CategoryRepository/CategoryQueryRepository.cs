using System;
using Domain.Entities;
using Domain.Repositories.AppEntities.CategoryRepository;
using Persistence.Context;
using Persistence.Repositories.GenericRepositories.AppDbContext;

namespace Persistence.Repositories.AppEntities.CategoryRepository
{
    public class CategoryQueryRepository : AppQueryRepository<Category>, ICategoryQueryRepository
    {
        public CategoryQueryRepository(AppDbContext context) : base(context)
        {
        }
    }
}

