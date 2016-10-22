using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace GenericRepositoryUntility.Repository
{
    public abstract class Repository<TEntity, TContext> : IRepository<TEntity> where TEntity : class where TContext:DbContext, new()
    {
        private TContext _entities = new TContext();
        public TContext Context
        {

            get { return _entities; }
            set { _entities = value; }
        }

        public virtual void Add(TEntity entity)
        {
            _entities.Set<TEntity>().Add(entity);
        }
        public virtual void Add(IEnumerable<TEntity> entities)
        {
            _entities.Set<TEntity>().AddRange(entities);
        }

        public virtual void Edit(TEntity entity)
        {
            _entities.Entry(entity).State = EntityState.Modified; 
        }

        public virtual void Save()
        {
            _entities.SaveChanges();
        }

        public virtual void Delete(TEntity entity)
        {
            _entities.Set<TEntity>().Remove(entity);
        }

        public virtual IQueryable<TEntity> GetAll()
        {
            return _entities.Set<TEntity>();
        }

        public virtual IQueryable<TEntity> FindBy(Expression<Func<TEntity, bool>> expression)
        {
            return _entities.Set<TEntity>().Where(expression);
        }
    }
}
