using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace TaskPlanner.Data.Repositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> predicate);
        Task<List<TEntity>> GetAsync(Expression<Func<TEntity, bool>> predicate);
        Task<TEntity> GetByIDAsync(object id);
        void Insert(IEnumerable<TEntity> entities);
        void Insert(TEntity entity);
        void Update(TEntity entityToUpdate);
        void Update(IEnumerable<TEntity> entities);
        void Delete(object id);
        void Delete(TEntity entityToDelete);
        void Delete(IEnumerable<TEntity> entities);
        Task<bool> Exists(Expression<Func<TEntity, bool>> predicate);
        Task<int> SaveAsync();
    }
}
