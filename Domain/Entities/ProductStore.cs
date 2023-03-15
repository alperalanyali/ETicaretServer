using System;
using System.ComponentModel.DataAnnotations.Schema;
using Domain.Abstractions;

namespace Domain.Entities
{
	public class ProductStore:Entity
	{

        public ProductStore()
        {

        }
        public ProductStore(string code,string name,string description,string imageUrl,Guid quantityTypeId,string storeId,decimal price,int inStock)
        {
			Id = Guid.NewGuid();
			//ProductId = new Guid(productId);
			StoreId = new Guid(storeId);
            Price = price;
            Name = name;
            Code = code;
            Description = description;
            ImageUrl = imageUrl;
            QuantityTypeId = quantityTypeId;
            InStock = inStock;
        }
        public string Code { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        [ForeignKey("QantityTypes")]
        public Guid QuantityTypeId { get; set; }
        public QuantityType QuantityType { get; set; }





        public ICollection<ProductCategory> ProductCategories { get; set; }

        //[ForeignKey("Product")]
        //public Guid ProductId { get; set; }
        //public Product Product { get; set; }

        [ForeignKey("Stores")]
        public Guid StoreId { get; set; }
		public Store Store { get; set; }

		public decimal Price { get; set; }
        public int InStock;



	}
}

