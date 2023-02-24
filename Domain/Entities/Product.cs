using System;
using System.ComponentModel.DataAnnotations.Schema;
using Domain.Abstractions;

namespace Domain.Entities
{
	public class Product:Entity
	{
		public Product()
		{

		}

		public Product(string name,string code,Guid quantityTypeId,string imageUrl,decimal price)
		{
			Id = Guid.NewGuid();
			Code = code;
			Name = name;
			QuantityTypeId = quantityTypeId;
			ImageUrl = imageUrl;
			Price = price;
		}
		public string Code { get; set; }

		public string Name { get; set; }

		[ForeignKey("QantityTypes")]
		public Guid QuantityTypeId { get; set; }
		public QuantityType QuantityType{ get; set; }

		public string ImageUrl { get; set; }

		public decimal Price { get; set; }		
	}
}

