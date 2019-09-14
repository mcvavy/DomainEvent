using System;
using Domain_Event.Core.Events;

namespace Domain_Event.Core.Entities
{
    public class Order
    {
        public Guid OrderId { get; private set; }
        public DateTime OrderDate { get; private set; }
        public int NumberOfItems { get; set; }
        public string OrderName { get; private set; }
        
        public Order(int numberOfItems, string orderName)
        {
            OrderId = Guid.NewGuid();
            OrderDate = DateTime.UtcNow;
            NumberOfItems = numberOfItems;
            OrderName = orderName;
        }

        public void OrderComplete()
        {
            DomainEvent.Raise(new OrderCompletedEvent(DateTime.UtcNow, this));
        }
    }
}