﻿using System;
namespace Application.Features.AppEntities.ProductStoreFeatures.Commands.CreateProductStore
{
	public sealed record CreateProductStoreCommandResponse(
		string Data,
		string Message = "Mağazına ürün başarılı şekilde eklenmiştir"
		);
	
}

