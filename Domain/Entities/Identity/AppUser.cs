using System;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
namespace Domain.Entities.Identity
{
	public class AppUser:IdentityUser<Guid>
	{
		public string FullName { get; set; }
		public string RefreshToken { get; set; }
		public DateTime RefreshTokenExpires { get; set; }

		[ForeignKey("Role")]
		public Guid RoleId { get; set; }
		public AppRole Role { get; set; }

		//[ForeignKey("Store")]
		public Guid? StoreId { get; set; }
		//public Store Store { get; set; }

		public string MailConfirmCode { get; set; }
		public bool IsMailConfirmed { get; set; }

		public string ForgotPasswordCode { get; set; }
		public bool IsForgotPasswordCodeActive { get; set; }


		public ICollection<Order> Orders { get; set; }
	}
}

