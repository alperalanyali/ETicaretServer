﻿using System;
using Domain.Dtos;

namespace Application.Features.AppEntities.OrderFeatures.Commands.CreateOrder
{
	public sealed record CreateOrderCommandResponse(        
        string Message ="Sepetiniz başarılı şekilde siparişe dönüştü"
		);
	
}

