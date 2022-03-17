using Microsoft.AspNetCore.Components;

namespace EcommerceWeb.Client.Pages
{
    public partial class Index:ComponentBase
    {
        public bool loading { get; set; } = true;
        protected override Task OnInitializedAsync()
        {
            return base.OnInitializedAsync();
            loading = false;
        }
    }
}
