using DDD.Domain.SeedWork;

namespace DDD.Domain.AggregateModels.OrderModels
{
    public class Address : ValueObject
    {
        public string? City { get; set; }
        public string? Country { get; set; }
        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return City;
            yield return Country;
        }
    }
}