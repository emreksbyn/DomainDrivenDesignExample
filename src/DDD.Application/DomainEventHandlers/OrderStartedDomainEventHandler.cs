using DDD.Application.Repositories;
using DDD.Domain.AggregateModels.BuyerModels;
using DDD.Domain.Events;
using MediatR;

namespace DDD.Application.DomainEventHandlers
{
    public class OrderStartedDomainEventHandler : INotificationHandler<OrderStartedDomainEvent>
    {
        private readonly IBuyerRepository _buyerRepository;

        public OrderStartedDomainEventHandler(IBuyerRepository buyerRepository)
        {
            _buyerRepository = buyerRepository;
        }

        public Task Handle(OrderStartedDomainEvent notification, CancellationToken cancellationToken)
        {
            if (notification.Order.UserName == "")
            {
                var buyer = new Buyer(notification.UserName);
                //_buyerRepository.Add(buyer); // Create Buyer and get new id

                // set Order's BuyerId
            }
            return Task.CompletedTask;
        }
    }
}