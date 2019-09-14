using System;
using System.Xml.Linq;
using Domain_Event.Core.Entities;
using Domain_Event.Core.Events;
using Domain_Event.Infrastructure.Handlers;
using NUnit.Framework;

namespace Domain_Event.Test
{
    [TestFixture]
    public class DomainEventTestShould
    {
        [Test]
        public void ReturnValue_That_WasPassed_In_TheEvent()
        {
            var o = new Order(20, "Hey");
            Order order = null;
            DomainEvent.Register<OrderCompletedEvent>(x => order = x.Order);
            
            o.OrderComplete();
            Assert.AreEqual(order, o);
        }
    }
}