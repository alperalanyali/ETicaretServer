using System;
using Microsoft.AspNetCore.Identity;

namespace Domain.Entities.Identity
{
	public class AppRole:IdentityRole<Guid>
	{
		public AppRole()
		{

		}

		public AppRole(string title,string code,string name)
		{
			Id = Guid.NewGuid();
			Title = title;
			Code = code;
		}

		public string Title { get; set; }
		public string Code { get; set; }
	}
}

