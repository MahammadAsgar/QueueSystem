using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using QueueSystem.Domain.Entities;
using QueueSystem.Domain.Entities.Users;
using QueueSystem.Domain.EntitiesConfiguration;
using QueueSystem.Domain.EntitiesConfiguration.UserConfiguration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            builder.Entity<QueueTicket>()
                .HasOne(q => q.Customer)
                .WithMany()
                .HasForeignKey(q => q.CustomerId);

            builder.Entity<QueueTicket>()
                .HasOne(q => q.User)
                .WithMany()
                .HasForeignKey(q => q.UserId);


            base.OnModelCreating(builder);
        }

        public DbSet<QueueTicket> Queues { get; set; }
        public DbSet<Service> Services { get; set; }
    }
}
