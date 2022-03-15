﻿using EcommerceWeb.Shared;
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
            var result = await httpClient.PostAsJsonAsync("api/product", NewProduct);
        }

        public async Task DeleteProduct(int id)
        {
            var result = await httpClient.DeleteAsync($"api/product/{id}");
        }

        public async Task<Product> GetProduct(int id)
        {
            var result = await httpClient.GetFromJsonAsync<Product>($"api/product/{id}");
            return result;
        }

        public async Task<IEnumerable<Product>> GetProducts()
        {
            var result = await httpClient.GetFromJsonAsync<IEnumerable<Product>>("api/product");
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
            await httpClient.PutAsJsonAsync("api/product", UpdateProduct);
        }
    }
}