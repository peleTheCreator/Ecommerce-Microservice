using Ecommerce.OrderMS.Domain.Model;
using System.Net.Http.Json;

namespace Ecommerce.OrderMS.Application.HttpClients
{
    public class ProductsMicroserviceClient
    {
        private readonly HttpClient _httpClient;

        public ProductsMicroserviceClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<ProductDTO?> GetProductByProductID(Guid productID)
        {
            HttpResponseMessage response = await _httpClient.GetAsync($"/gateway/products/search/product-id/{productID}");

            if (!response.IsSuccessStatusCode)
            {
                if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    return null;
                }
                else if (response.StatusCode == System.Net.HttpStatusCode.BadRequest)
                {
                    throw new HttpRequestException("Bad request", null, System.Net.HttpStatusCode.BadRequest);
                }
                else
                {
                    throw new HttpRequestException($"Http request failed with status code {response.StatusCode}");
                }
            }
            ProductDTO? product = null;
            try
            {
                 product = await response.Content.ReadFromJsonAsync<ProductDTO>();

            }
            catch (Exception ex)
            {

                throw;
            }

            if (product == null)
            {
                throw new ArgumentException("Invalid Product ID");
            }

            return product;
        }
    }

}
