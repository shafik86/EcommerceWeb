using EcommerceWeb.Shared;

namespace EcommerceWeb.Server.Models.Repository
{
    public interface IConditionRepository
    {
        IEnumerable<Condition> GetConditions();
        Condition GetCondition(int conditionId);
        
    }
}
