using EcommerceWeb.Shared;

namespace EcommerceWeb.Server.Models.Repository
{
    public interface IConditionRepository
    {
        Task<IEnumerable<Condition>> GetConditions();
        Task<Condition> GetCondition(int conditionId);
        
    }
}
