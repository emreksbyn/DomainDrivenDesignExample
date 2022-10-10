using DDD.Domain.AggregateModels.OrderModels;
using MediatR;

namespace DDD.Domain.Events
{
    public class OrderStartedDomainEvent : INotification
    {
        public string UserName { get; set; }
        public Order? Order { get; set; }

        public OrderStartedDomainEvent(string userName, Order? order)
        {
            UserName = userName;
            Order = order;
        }
    }
}