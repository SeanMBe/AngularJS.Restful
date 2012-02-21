using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ECommerce.WCF.Restful
{
    [DataContract]
    public class Cart
    {
        public Cart(IEnumerable<Tuple<Product, int>> products)
        {
            this.Products = products;
        }

        [DataMember]
        public IEnumerable<Tuple<Product, int>> Products { get; private set; }

        public bool Equals(Cart other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Equals(other.Products, Products);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof (Cart)) return false;
            return Equals((Cart) obj);
        }

        public override int GetHashCode()
        {
            return (Products != null ? Products.GetHashCode() : 0);
        }
    }
}