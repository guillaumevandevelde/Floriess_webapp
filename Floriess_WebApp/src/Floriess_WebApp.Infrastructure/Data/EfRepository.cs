using Ardalis.Specification.EntityFrameworkCore;
using Floriess_WebApp.SharedKernel.Interfaces;

namespace Floriess_WebApp.Infrastructure.Data
{
    // inherit from Ardalis.Specification type
    public class EfRepository<T> : RepositoryBase<T>, IReadRepository<T>, IRepository<T> where T : class, IAggregateRoot
    {
        public EfRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}