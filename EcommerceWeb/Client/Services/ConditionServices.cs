using EcommerceWeb.Shared;
using System.Net.Http.Json;

namespace EcommerceWeb.Client.Services
{
    public class ConditionServices : IConditionServices
    {
        private HttpClient httpClient;
        public ConditionServices(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<Condition> GetConditionById(int Id)
        {
            return await httpClient.GetFromJsonAsync<Condition>($"api/Condition/{Id}");
        }

        public async Task<IEnumerable<Condition>> GetConditions()
        {
            return await httpClient.GetFromJsonAsync<Condition[]>("api/Condition");
        }
    }
}
