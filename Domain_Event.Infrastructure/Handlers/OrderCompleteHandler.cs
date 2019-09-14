using System;
using Domain_Event.Core.Events;
using Domain_Event.Core.Interfaces;

namespace Domain_Event.Infrastructure.Handlers
{
    public class OrderCompleteHandler : IDomainHandler<OrderCompletedEvent>
    {
        public void Hanle(OrderCompletedEvent @event)
        {
            @event.Order.NumberOfItems = 100;
            Console.WriteLine($"Order Information: \n=======================\nOrder completed on {@event.OrderCreatedDate.ToShortDateString()} at {@event.OrderCreatedDate:HH:mm:ss tt}\nID: {@event.Order.OrderId}\nNumber of order items: {@event.Order.NumberOfItems}\n____________________________________");
        }
    }
}