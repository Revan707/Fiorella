﻿using Fiorella.Domain.Entities;
using System.Linq.Expressions;

namespace Fiorella.Aplication.Abstraction.Repository;

public interface IReadRepository<T>:IRepository<T> where T :BaseEntity, new()
{
    IQueryable<T> GetAll(bool isTracking = true, params string[] includes);
    IQueryable<T> GetAllFiltered(Expression<Func<T, bool>> expression, int take, int skip, bool isTracking = true, params string[] includes);
    IQueryable<T> GetAllFilteredOrderBy(Expression<Func<T, bool>> expression, int take, int skip, Expression<Func<T, object>> expressionOrder, bool isOrdered = true, bool isTracking = true, params string[] includes);
    Task<T> GetByIdAsync(int Id);
    Task<T> GetByExpression(Expression<Func<T, bool>> expression, bool isTracking = true);
}
