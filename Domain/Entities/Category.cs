using System;
using Domain.Abstractions;

namespace Domain.Entities
{
	public class Category:Entity
	{
        public Category()
        {

        }
        public Category(int itemNo,string code,string name)
        {
            Id = Guid.NewGuid();
            ItemNo = itemNo;
            Code = code;
            Name = name;
        }
        public int ItemNo { get; set; }
        public string  Code { get; set; }
		public string Name { get; set; }
        public bool IsActive { get; set; } = true;

		
	}
}

