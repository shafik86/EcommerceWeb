using EcommerceWeb.Shared;

namespace EcommerceWeb.Server.Models.Repository
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> SearchProduct(string name, Metal? metal);
        Task<IEnumerable<Product>> GetProducts();
        Task<Product?> GetProduct(int productId);
        Task<Product> GetProductByName(string name);
        Task<IEnumerable<Product>> GetProductByMetal(Metal? metal);
        Task<Product> AddProduct(Product product);
        Task<Product> UpdateProduct(Product product);
        Task<Product> DeleteProduct(int productId);
    }
}
