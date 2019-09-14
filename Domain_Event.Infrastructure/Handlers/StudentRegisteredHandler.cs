using System;
using Domain_Event.Core.Events;
using Domain_Event.Core.Interfaces;

namespace Domain_Event.Infrastructure.Handlers
{
    public class StudentRegisteredHandler : IDomainHandler<StudentRegisterEvent>
    {
        public void Hanle(StudentRegisterEvent @event)
        {
            Console.WriteLine($"{@event.Student.Title}. {@event.Student.FirstName} {@event.Student.LastName} registration is now complete");
            Console.WriteLine("_____________________________\n");
        }
    }
}