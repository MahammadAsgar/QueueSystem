using Microsoft.EntityFrameworkCore;
using QueueSystem.Domain.Context;
using QueueSystem.Domain.Entities;

namespace QueueSystem.Application.UnitOfWorks
{
    public class UnitOfWork(QueueDbContext _queueDbContext) : IUnitOfWork
    {
        public void Commit()
        {
            var tracker = _queueDbContext.ChangeTracker.Entries<BaseEntity>();
            foreach (var item in tracker)
            {
                if (item.State == EntityState.Added)
                {
                    item.Entity.AddDate = DateTime.Now;
                }
                else if (item.State == EntityState.Modified)
                {
                    item.Entity.UpdateDate = DateTime.Now;
                }
                else if (item.State == EntityState.Deleted)
                {
                    item.Entity.DeletedDate = DateTime.Now;
                }
            }
            _queueDbContext.SaveChanges();
        }

        public async Task CommitAsync()
        {
            var tracker = _queueDbContext.ChangeTracker.Entries<BaseEntity>();
            foreach (var item in tracker)
            {
                if (item.State == EntityState.Added)
                {
                    item.Entity.AddDate = DateTime.Now;
                }
                else if (item.State == EntityState.Modified)
                {
                    item.Entity.UpdateDate = DateTime.Now;
                }
                else if (item.State == EntityState.Deleted)
                {
                    item.Entity.DeletedDate = DateTime.Now;
                }
            }
            await _queueDbContext.SaveChangesAsync();
        }
    }
}
