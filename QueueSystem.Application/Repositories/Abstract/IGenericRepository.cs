using QueueSystem.Domain.Entities;
using System.Linq.Expressions;

namespace QueueSystem.Application.Repositories.Abstract
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        Task<T> GetById(int id);
        Task<IEnumerable<T>> GetAll();
        IQueryable<T> Where(Expression<Func<T, bool>> predicate);
        void Add(T entity);
        Task AddAsync(T entity);
        void Remove(T entity);
        void UpdateAsync(T entity);
    }
}
