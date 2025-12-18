using Microsoft.EntityFrameworkCore;
using QueueSystem.Application.Repositories.Abstract;
using QueueSystem.Domain.Context;
using QueueSystem.Domain.Entities;
using System.Linq.Expressions;


namespace QueueSystem.Application.Repositories.Concrete
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        readonly QueueDbContext _queueDbContext;
        readonly DbSet<T> _dbSet;
        public GenericRepository(QueueDbContext queueDbContext)
        {
            _dbSet = queueDbContext.Set<T>();
            _queueDbContext = queueDbContext;
        }
        public void Add(T entity)
        {
            _dbSet.Add(entity);
        }

        public async Task AddAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<T> GetById(int id)
        {
            return await _dbSet.FirstOrDefaultAsync(x => x.Id == id);
        }

        public void Remove(T entity)
        {
            _dbSet.Remove(entity);
        }

        public void UpdateAsync(T entity)
        {
            _dbSet.Update(entity);
        }

        public IQueryable<T> Where(Expression<Func<T, bool>> predicate)
        {
            return _dbSet.Where(predicate);
        }

    }
}
