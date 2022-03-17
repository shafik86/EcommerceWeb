using EcommerceWeb.Shared;
using System.Threading.Tasks;
namespace EcommerceWeb.Client.Services
{
    public interface IProductServices
    {
        IEnumerable<Product> products { get; set; }
        //Task<IEnumerable<Product>> GetProductsMetal(Metal? metal);
        Task<IEnumerable<Product>> GetProducts();
        Task CreateProduct(Product NewProduct);
        Task UpdateProduct(Product UpdateProduct);
        Task<IEnumerable<Product>> SearcProduct(string metal);
        Task DeleteProduct(int id);
        Task<Product> GetProduct(int id);
    }
}
