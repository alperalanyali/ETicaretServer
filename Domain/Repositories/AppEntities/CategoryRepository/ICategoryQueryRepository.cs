﻿using System;
using Domain.Entities;
using Domain.Repository.GenericRepositories.AppDbContext;

namespace Domain.Repositories.AppEntities.CategoryRepository
{
	public interface ICategoryQueryRepository: IAppQueryRepository<Category>
    {
	}
}

