using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace ECommerce.WCF.Restful
{
    [ServiceContract]
    public interface IEcommerceService
    {
        [WebInvoke(Method = "POST", UriTemplate = "/products/{productId}", 
            RequestFormat=WebMessageFormat.Json, ResponseFormat=WebMessageFormat.Json)]
        [OperationContract]
        void AddProductsToCart(int quantity, Product product);

        [WebGet(UriTemplate = "/cart",
            RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        [OperationContract]
        Cart GetContentsOfCart();

        [WebGet(UriTemplate = "/products",
            RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        IEnumerable<Product> GetProductsForSale();
    }
}
