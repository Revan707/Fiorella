using Fiorella.Aplication.Abstraction.Repository;
using Fiorella.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Fiorella.Persistence.Implementations.Repositories;

public class ReadRepository<T> : IReadRepository<T> where T : BaseEntity, new()
{
}
