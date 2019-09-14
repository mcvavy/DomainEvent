using Domain_Event.Core.Events;
using Domain_Event.Core.Interfaces;

namespace Domain_Event.Core.Entities
{
    public class SendEmailEvent : IDomainEvent
    {
        public Email Email { get; set; }
    }
}