using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace CalendArt.Core.Repositories
{
    // Interface for repository pattern
    public interface IRepository<TEntity> where TEntity : class
    {
        TEntity Get(int id);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);

        void Add(TEntity entity);
        void AddList(IEnumerable<TEntity> entities);

        void Remove(TEntity entity);
        void RemoveList(IEnumerable<TEntity> entities);
    }
}