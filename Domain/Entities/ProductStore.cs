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
        public ProductStore(string productId,string storeId,decimal price,bool useProductPrice)
        {
			Id = Guid.NewGuid();
			ProductId = new Guid(productId);
			StoreId = new Guid(storeId);
			Price = price;
			UseProductPrice = useProductPrice;
        }
        [ForeignKey("Product")]
		public Guid ProductId { get; set; }
		public Product Product { get; set; }

        [ForeignKey("Store")]
        public Guid StoreId { get; set; }
		public Store Store { get; set; }
		public decimal Price { get; set; }
		public bool UseProductPrice { get; set; } = false;



	}
}

