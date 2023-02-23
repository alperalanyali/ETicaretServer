using System;
using Domain.Abstractions;

namespace Domain.Entities
{
	public class PaymentType:Entity
	{
		public PaymentType()
		{

		}
		public PaymentType(string code,string name)
		{
			Id = Guid.NewGuid();
			Code = code;
			Name = name;
		}
		public string Code { get; set; }
		public string Name { get; set; }
	}
}

