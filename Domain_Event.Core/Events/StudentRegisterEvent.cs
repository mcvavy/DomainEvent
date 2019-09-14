using Domain_Event.Core.Entities;
using Domain_Event.Core.Interfaces;

namespace Domain_Event.Core.Events
{
    public class StudentRegisterEvent : IDomainEvent
    {
        public Student Student { get; set; }
    }
}