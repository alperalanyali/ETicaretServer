using System;
using Microsoft.AspNetCore.Identity;
namespace Domain.Entities.Identity
{
	public class AppUser:IdentityUser<Guid>
	{
		public string FullName { get; set; }
		public string RefreshToken { get; set; }
		public DateTime RefreshTokenExpires { get; set; }

		public ICollection<Order> Orders { get; set; }
	}
}

