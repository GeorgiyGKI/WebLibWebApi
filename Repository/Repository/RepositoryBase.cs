using Contracts;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public abstract class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        protected RepositoryContext RepositoryContext;
        public RepositoryBase(RepositoryContext repositoryContext) => RepositoryContext = repositoryContext;
        public IQueryable<TEntity> FindAll(bool trackChanges) => !trackChanges ? RepositoryContext.Set<TEntity>().AsNoTracking()
                                                                               : RepositoryContext.Set<TEntity>();
        public IQueryable<TEntity> FindByCondition(Expression<Func<TEntity, bool>> expression, bool trackChanges) =>
        !trackChanges ? RepositoryContext.Set<TEntity>().Where(expression).AsNoTracking()
                      : RepositoryContext.Set<TEntity>().Where(expression);

        public void Create(TEntity entity) => RepositoryContext.Set<TEntity>().Add(entity);
        public void Update(TEntity entity) => RepositoryContext.Set<TEntity>().Update(entity);
        public void Delete(TEntity entity) => RepositoryContext.Set<TEntity>().Remove(entity);
    }
}
