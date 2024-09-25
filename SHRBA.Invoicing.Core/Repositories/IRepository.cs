using System.Linq.Expressions;

namespace SHRBA.Invoicing.Core.Repositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        public void Add(TEntity entity);
        public void AddRange(IEnumerable<TEntity> entities);
        public TEntity GetById(int id);
        public IEnumerable<TEntity> GetAll();
        public void Remove(TEntity entity);
        public void RemoveRange(IEnumerable<TEntity> entities);
        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);

        public TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicate);
    }
}
