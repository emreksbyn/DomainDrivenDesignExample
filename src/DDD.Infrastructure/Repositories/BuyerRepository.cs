using DDD.Application.Repositories;

namespace DDD.Infrastructure.Repositories
{
    public class BuyerRepository : IBuyerRepository
    {
        public Task<int> SaveChangesAsync()
        {
            return Task.FromResult(1);
        }
    }
}