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
                if (Id != string.Empty || Id != "")
                {
                    int.TryParse(Id, out int ProductId);
                    PageHeader += Id;
                }
            }
            return base.OnInitializedAsync();
        }

        protected override Task OnParametersSetAsync()
        {
            if (Metal != string.Empty || Metal != "")
            {
                PageHeader = "Products " + Metal;
                if (Id != string.Empty || Id != "")
                {
                    int.TryParse(Id, out int ProductId);
                    PageHeader += Id;
                }
            }
            return base.OnParametersSetAsync();
        }
    }
}
