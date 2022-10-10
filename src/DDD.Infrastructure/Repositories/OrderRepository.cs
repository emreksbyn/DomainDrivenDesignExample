using DDD.Application.Repositories;

namespace DDD.Infrastructure.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        public Task<int> SaveChangesAsync()
        {
            return Task.FromResult(67);
        }
    }
}