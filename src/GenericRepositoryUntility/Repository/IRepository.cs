using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace GenericRepositoryUntility
{
    public interface IRepository<TEntity> where TEntity : class
    {
        void Add(TEntity entity);
        void Add(IEnumerable<TEntity> entities);
        void Edit(TEntity entity);
        void Save();
        void Delete(TEntity entity);
        IQueryable<TEntity> GetAll();
        IQueryable<TEntity> FindBy(Expression<Func<TEntity, bool>> expression);
    }
}
