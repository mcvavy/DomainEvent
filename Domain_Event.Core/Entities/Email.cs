using Domain_Event.Core.Events;

namespace Domain_Event.Core.Entities
{
    public class Email
    {
        public string RecipientEmail { get; private set; }
        public string SenderEmail { get; private set; }
        public string Subject { get; private set; }
        public string Message { get; private set; }
        
        public Email(string recipientEmail, string senderEmail, string subject, string message)
        {
            RecipientEmail = recipientEmail;
            SenderEmail = senderEmail;
            Subject = subject;
            Message = message;
        }

        public void RaiseEmailSent()
        {
            DomainEvent.Raise(new SendEmailEvent{ Email = this});
        }
    }
}