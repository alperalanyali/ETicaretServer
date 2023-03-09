using System;
using Domain.Abstractions;

namespace Domain.Entities
{
	public class IyzicoSetting:Entity
	{
		public string Api { get; set; }
		public string SecretKey { get; set; }
		public string BaseUrl { get; set; }

	}
}

