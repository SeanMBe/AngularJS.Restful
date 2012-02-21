using System;
using System.Collections.Generic;
using System.Linq;

namespace ECommerce.WCF.Restful
{
    public class ECommerceService : IEcommerceService
    {
        private Dictionary<Product, int> _products;

        public ECommerceService()
        {
            _products = new Dictionary<Product, int>();
        }

        public void AddProductsToCart(int quantity, Product product)
        {
            if(_products.ContainsKey(product))
            {
                _products[product] += quantity;
            }
            else
            {
                _products.Add(product, quantity);    
            }
        }

        public Cart GetContentsOfCart()
        {
            return new Cart(_products.Select(p => new Tuple<Product,int>(p.Key,p.Value)));
        }

        public IEnumerable<Product> GetProductsForSale()
        {
            return new List<Product>
                       {
                           new Product {Id = 1, Name = "OptiMax Whey 5 Lbs"},
                           new Product {Id = 2, Name = "Weider Egg Protein 2 Lbs"}
                       };
        }
    }
}
