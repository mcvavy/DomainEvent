using System;
using Domain_Event.Core.Entities;
using Domain_Event.Core.Interfaces;

namespace Domain_Event.Core.Events
{
    public class OrderCompletedEvent : IDomainEvent
    {
        public DateTime OrderCreatedDate { get; private set; }
        public Order Order { get; private set; }
        
        
        public OrderCompletedEvent(DateTime orderCreatedDate, Order order)
        {
            OrderCreatedDate = orderCreatedDate;
            Order = order;
        }
    }
}