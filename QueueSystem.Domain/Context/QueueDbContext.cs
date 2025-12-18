using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using QueueSystem.Domain.Entities;
using QueueSystem.Domain.EntitiesConfiguration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueSystem.Domain.Context
{
    public class QueueDbContext:DbContext
    {
        public QueueDbContext(DbContextOptions<QueueDbContext> options):base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.ConfigureWarnings(warnings =>
                warnings.Ignore(RelationalEventId.PendingModelChangesWarning));
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new PriorityConfiguration());

            /*builder.Entity<Queue>().
               .HasOne(x=>x.Priority)
               .
               .UsingEntity(j => j.ToTable("ArticleDisLikes"));

            builder.Entity<Article>()
                .HasMany(a => a.LikedBy)
                .WithMany(u => u.LikedPosts)
                .UsingEntity(j => j.ToTable("ArticleLikes"));

            builder.Entity<Article>()
                .HasMany(a => a.SavedBy)
                .WithMany(u => u.SavedPosts)
                .UsingEntity(j => j.ToTable("ArticleSaved"));


            builder.Entity<Article>()
                .HasOne(a => a.AppUser)
                .WithMany(a => a.Posts)
                .HasForeignKey(a => a.AppUserId)
                .OnDelete(DeleteBehavior.NoAction);

            //builder.Entity<AppUser>()
            //    .HasMany(a => a.Posts)
            //    .WithOne(a => a.AppUser)
            //    .HasForeignKey(a => a.AppUserId);

            */
            base.OnModelCreating(builder);
        }

        public DbSet<Queue> Queues { get; set; }
        public DbSet<Worker> Workers { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Priority> Priorities { get; set; }
        public DbSet<Status> Statuses { get; set; }
    }
}
