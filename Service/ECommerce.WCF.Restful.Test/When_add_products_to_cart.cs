using System;
using Machine.Specifications;
using MavenThought.Commons.Extensions;

namespace ECommerce.WCF.Restful.Test
{
    public class When_add_products_to_cart : context_specification<ECommerceService>
    {
        private Because of = () =>
                             Sut.AddProductsToCart(3, new Product { Id = 1, Name = "Anything" });

        private It should_have_expected_products_in_cart = () =>
                                                        Sut.GetContentsOfCart().Products.ShouldEqual(
                                                            Enumerable.Create(new Tuple<Product,int>(new Product { Id = 1, Name = "Anything" }, 3)));
    }

    public class When_add_same_product_twice_to_cart : context_specification<ECommerceService>
    {
        private Establish context = () => Sut.AddProductsToCart(3, new Product { Id = 1, Name = "Anything" });

        private Because of = () => Sut.AddProductsToCart(3, new Product { Id = 1, Name = "Anything" });                                                              

        private It should_have_expected_products_in_cart = () =>
                                                        Sut.GetContentsOfCart().Products.ShouldEqual(
                                                            Enumerable.Create(new Tuple<Product, int>(new Product { Id = 1, Name = "Anything" }, 6)));
    }
}