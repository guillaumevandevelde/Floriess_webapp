using MediatR;

namespace Floriess_WebApp.SharedKernel
{
    public abstract class DomainEventBase : INotification
    {
        public DateTime DateOccurred { get; protected set; } = DateTime.UtcNow;
    }
}