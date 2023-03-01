using System;
namespace Domain.Dtos
{
	public class ProductDto
	{
		public Guid Id { get; set; }
		public string Code { get; set; }
		public string  Name { get; set; }
		public decimal Price { get; set; }
		public string ImageUrl { get; set; }
		public string Description { get; set; }
		public List<CategoryDto> Categories { get; set; }

		

	}
}

