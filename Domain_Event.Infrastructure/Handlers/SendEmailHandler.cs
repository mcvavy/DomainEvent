using System;
using Domain_Event.Core.Entities;
using Domain_Event.Core.Events;
using Domain_Event.Core.Interfaces;

namespace Domain_Event.Infrastructure.Handlers
{
    public class SendEmailHandler : IDomainHandler<SendEmailEvent>
    {
        public void Hanle(SendEmailEvent @event)
        {
            Console.WriteLine($"Email to the address {@event.Email.RecipientEmail} has been sent!");
            Console.WriteLine("_________________________\n");
        }
    }
}