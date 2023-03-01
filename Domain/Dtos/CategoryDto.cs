using System;
namespace Domain.Dtos
{
	public class CategoryDto
	{
		public CategoryDto()
		{

		}
		public Guid Id { get; set; }
		public string  Code { get; set; }
		public string Name { get; set; }
		public CategoryDto(Guid id,string code,string name)
		{
			Id = id;
			Code = code;
			Name = name;

		}
	}
}

