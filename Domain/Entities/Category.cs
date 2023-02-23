using System;
using Domain.Abstractions;

namespace Domain.Entities
{
	public class Category:Entity
	{
        public Category()
        {

        }
        public Category(string code,string name)
        {
            Id = Guid.NewGuid();
            Code = code;
            Name = name;
        }
        public string  Code { get; set; }
		public string Name { get; set; }
        public bool IsActive { get; set; } = true;

		
	}
}

