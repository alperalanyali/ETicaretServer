﻿using System;
using Domain.Entities;
using Domain.Repository.GenericRepositories.AppDbContext;

namespace Domain.Repositories.AppEntities.ProductCategoryRepository
{
	public interface IProductCategoryQueryRepository:IAppQueryRepository<ProductCategory>
	{
	}
}

