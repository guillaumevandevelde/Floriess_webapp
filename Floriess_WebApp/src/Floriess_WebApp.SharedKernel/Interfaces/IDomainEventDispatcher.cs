
namespace Floriess_WebApp.SharedKernel.Interfaces
{
    public interface IDomainEventDispatcher
    {
        Task DispatchAndClearEvents(IEnumerable<EntityBase> entitiesWithEvents);
    }
}