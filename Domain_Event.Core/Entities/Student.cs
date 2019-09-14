using System;
using Domain_Event.Core.Events;
using Domain_Event.Core.Interfaces;

namespace Domain_Event.Core.Entities
{
    public class Student : IDomainEvent
    {
        public string StudentId { get; set; } = Guid.NewGuid().ToString();
        public string FirstName { get; private set; }
        public Title Title { get; private set; }
        public string LastName { get; private set; }
        
        public Student(Title title, string firstName, string lastName)
        {
            Title = title;
            FirstName = firstName;
            LastName = lastName;
        }

        public void RegisterStudent()
        {
            DomainEvent.Raise(new StudentRegisterEvent {Student = this});
        }
    }
}