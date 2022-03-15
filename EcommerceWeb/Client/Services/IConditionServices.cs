using EcommerceWeb.Shared;

namespace EcommerceWeb.Client.Services
{
    public interface IConditionServices
    {
        Task<IEnumerable<Condition>> GetConditions();
        Task<Condition> GetConditionById(int Id);
        //Condition GetCondition(Condition condition);

    }
}
