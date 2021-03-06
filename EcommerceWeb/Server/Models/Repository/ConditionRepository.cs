using EcommerceWeb.Server.Data;
using EcommerceWeb.Shared;
using Microsoft.EntityFrameworkCore;

namespace EcommerceWeb.Server.Models.Repository
{
    public class ConditionRepository : IConditionRepository
    {
        private readonly ApplicationDbContext appDbContext;

        public ConditionRepository(ApplicationDbContext applicationDbContext)
        {
            this.appDbContext = applicationDbContext;
        }
        public async Task<Condition> GetCondition(int conditionId)
        {
            return await appDbContext.Conditions.FirstOrDefaultAsync(e => e.ConditionId == conditionId);
        }

        public async Task<IEnumerable<Condition>> GetConditions()
        {
            return await appDbContext.Conditions.ToListAsync();
        }
    }
}
