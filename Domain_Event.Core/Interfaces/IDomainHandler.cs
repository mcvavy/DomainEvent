namespace Domain_Event.Core.Interfaces
{
    public interface IDomainHandler<T> where T : IDomainEvent
    {
        void Hanle(T @event);
    }
}