using Fiorella.Aplication.Abstraction.Repository;
using Fiorella.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Fiorella.Persistence.Implementations.Repositories;

public class WriteRepository<T> : IReadRepository<T> where T : BaseEntity, new()
{
    public DbSet<T> Table => throw new NotImplementedException();

    public Task AddAsync(T entity)
    {
        throw new NotImplementedException();
    }

    public Task AddRangeAsync(ICollection<T> entities)
    {
        throw new NotImplementedException();
    }

    public void Remove(T entity)
    {
        throw new NotImplementedException();
    }

    public void RemoveRange(ICollection<T> entities)
    {
        throw new NotImplementedException();
    }

    public Task SaveChangeAsync()
    {
        throw new NotImplementedException();
    }

    public void Update(T entity)
    {
        throw new NotImplementedException();
    }
}
