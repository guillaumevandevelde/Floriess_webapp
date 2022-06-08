using Ardalis.Specification;

namespace Floriess_WebApp.SharedKernel.Interfaces
{
    public interface IReadRepository<T> : IReadRepositoryBase<T> where T : class, IAggregateRoot
    {
    }
}