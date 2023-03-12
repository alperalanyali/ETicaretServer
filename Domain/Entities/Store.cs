using System;
using Domain.Abstractions;

namespace Domain.Entities
{
	public class Store:Entity
	{

		public Store()
		{

		}

		public Store(string storeName,string address)
		{
			Id = Guid.NewGuid();
			StoreName = storeName;
			Address = address;

		}

		public string StoreName { get; set; }
		public string Address { get; set; }

		

	}
}

