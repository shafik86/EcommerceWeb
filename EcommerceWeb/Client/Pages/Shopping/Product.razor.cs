using Microsoft.AspNetCore.Components;

namespace EcommerceWeb.Client.Pages.Shopping
{
    public partial class Product : ComponentBase
    {
        [Parameter]
        public string Id { get; set; }
        [Parameter]
        public string Metal { get; set; }

        public string PageHeader { get; set; }

        protected override Task OnInitializedAsync()
        {
            if (Metal != string.Empty || Metal != "")
            {
                PageHeader = "Products " + Metal;
            }
            return base.OnInitializedAsync();
        }
    }
}
