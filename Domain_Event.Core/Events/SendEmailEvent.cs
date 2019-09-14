using Domain_Event.Core.Entities;
using Domain_Event.Core.Interfaces;

namespace Domain_Event.Core.Events
{
    public class SendEmailEvent : IDomainEvent
    {
        public Email Email { get; set; }
    }
}