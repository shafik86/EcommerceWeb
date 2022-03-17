using EcommerceWeb.Client.Services;
using EcommerceWeb.Shared;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;

namespace EcommerceWeb.Client.Pages
{
    public partial class ProductTable : ComponentBase
    {
        [Inject]
        public IProductServices ProductServices { get; set; }
        public IEnumerable<Product> Products { get; set; } = new List<Product>();
        private bool dense = false;
        private bool hover = true;
        private bool striped = false;
        private bool bordered = false;
        private string searchString1 = "";
        private Product selectedItem1 = null;
        private HashSet<Product> selectedItems = new HashSet<Product>();

        //private IEnumerable<Product> Elements = new List<Product>();

        protected override async Task OnInitializedAsync()
        {
            //Elements = await httpClient.GetFromJsonAsync<List<Element>>("webapi/periodictable");
            //var result = await ProductServices.GetProducts();
            Products = await ProductServices.GetProducts();
        }

        private bool FilterFunc1(Product element) => FilterFunc(element, searchString1);

        private bool FilterFunc(Product element, string searchString)
        {
            if (string.IsNullOrWhiteSpace(searchString))
                return true;
            if (element.Name.Contains(searchString, StringComparison.OrdinalIgnoreCase))
                return true;
            if (element.Manufacture.Contains(searchString, StringComparison.OrdinalIgnoreCase))
                return true;
            if ($"{element.SKU} {element.Price} {element.Type}".Contains(searchString))
                return true;
            return false;
        }
    }
}
