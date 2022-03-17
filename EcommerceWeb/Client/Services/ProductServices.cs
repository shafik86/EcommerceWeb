using EcommerceWeb.Shared;
using System.Net.Http.Json;
using System.Net.Http;
using Microsoft.AspNetCore.Components;

namespace EcommerceWeb.Client.Services
{
    public class ProductServices : IProductServices
    {
        private HttpClient httpClient;

        public ProductServices(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public IEnumerable<Product> products { get ; set; } = Enumerable.Empty<Product>();

        public async Task CreateProduct(Product NewProduct)
        {
            var result = await httpClient.PostAsJsonAsync("api/products", NewProduct);
        }

        public async Task DeleteProduct(int id)
        {
            var result = await httpClient.DeleteAsync($"api/products/{id}");
        }

        public async Task<Product> GetProduct(int id)
        {
            var result = await httpClient.GetFromJsonAsync<Product>($"api/products/{id}");
            return result;
        }

        public async Task<IEnumerable<Product>> SearcProduct(string? metal, string? types)
        {
            var result = await httpClient.GetFromJsonAsync<IEnumerable<Product>>($"api/products/search?metal={metal}&types={types}");
            return result;
        }

        public async Task<IEnumerable<Product>> GetProducts()
        {
            var result = await httpClient.GetFromJsonAsync<IEnumerable<Product>>("api/products");
            if (result != null)
            {
                return result;
            }
            else
            {
                return Enumerable.Empty<Product>();
            }
        }

        

        public async Task UpdateProduct(Product UpdateProduct)
        {
            await httpClient.PutAsJsonAsync("api/products", UpdateProduct);
        }
    }
}
