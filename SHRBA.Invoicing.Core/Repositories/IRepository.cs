using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

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
