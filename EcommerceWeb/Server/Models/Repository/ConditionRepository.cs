using EcommerceWeb.Server.Data;
using EcommerceWeb.Shared;

namespace EcommerceWeb.Server.Models.Repository
{
    public class ConditionRepository : IConditionRepository
    {
        private readonly ApplicationDbContext appDbContext;

        public ConditionRepository(ApplicationDbContext applicationDbContext)
        {
            this.appDbContext = applicationDbContext;
        }
        public Condition GetCondition(int conditionId)
        {
            return appDbContext.Conditions
                .FirstOrDefault(d => d.ConditionId == conditionId);
        }

        public IEnumerable<Condition> GetConditions()
        {
            return appDbContext.Conditions.ToList();
        }
    }
}
