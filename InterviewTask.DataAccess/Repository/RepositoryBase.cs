using InterviewTask.Common.Repository;
using InterviewTask.DataAccess.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace InterviewTask.DataAccess.Repository
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        protected ApplicationContext dbContext;

        public RepositoryBase(ApplicationContext context)
        {
            this.dbContext = context;
        }

        public async Task AddAsync(TEntity entity) => await dbContext.Set<TEntity>().AddAsync(entity);

        public async Task AddRangeAsync(IEnumerable<TEntity> entities) => await dbContext.Set<TEntity>().AddRangeAsync(entities);

        public async Task<IEnumerable<TEntity>> FilterByAsync(Expression<Func<TEntity, bool>> predicate) => await dbContext.Set<TEntity>().Where(predicate).ToListAsync();

        public async Task<IEnumerable<TEntity>> GetAllAsync() => await dbContext.Set<TEntity>().ToListAsync();

        public async Task<TEntity> GetByIdAsync(int id) => await dbContext.Set<TEntity>().FindAsync(id);

        public void Remove(TEntity entity) => dbContext.Set<TEntity>().Remove(entity);

        public void Update(TEntity entity) => dbContext.Set<TEntity>().Update(entity);
    }
}
