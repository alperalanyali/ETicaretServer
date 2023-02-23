using System;
namespace Domain.Abstractions
{
	public class Entity
	{
		public Guid Id { get; set; }
		public DateTime CreatedDate { get; set; }
		public DateTime? UpdatedDate { get; set; }
	}
}

