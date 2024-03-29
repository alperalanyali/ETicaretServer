﻿using System;
using Domain.Entities.Identity;

namespace Application.Features.AppEntities.AuthFeatures.Commands.Login
{
	public sealed record LoginCommandResponse(
		bool isSuccess,
		string Message,
		string Email,
		Guid UserId,
		string FullName,
		AppRole Role,
		string StoreId
		);
	
}

