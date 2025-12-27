using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using QueueSystem.Domain.Entities;
using QueueSystem.Domain.Entities.Users;
using QueueSystem.Domain.EntitiesConfiguration.UserConfiguration;

namespace QueueSystem.Domain.Context
{
    public class QueueDbContext : IdentityDbContext<AppUser, AppRole, int>
    {
        public QueueDbContext(DbContextOptions<QueueDbContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.ConfigureWarnings(warnings =>
                warnings.Ignore(RelationalEventId.PendingModelChangesWarning));
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new RoleConfiguration());

            builder.Entity<Ticket>()
                .HasOne(q => q.Customer)
                .WithMany()
                .HasForeignKey(q => q.CustomerId);

            builder.Entity<Ticket>()
                .HasOne(q => q.User)
                .WithMany()
                .HasForeignKey(q => q.UserId);


            base.OnModelCreating(builder);
        }

        public DbSet<Ticket> Queues { get; set; }
        public DbSet<Service> Services { get; set; }
    }
}
