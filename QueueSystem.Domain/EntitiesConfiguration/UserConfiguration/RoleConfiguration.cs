using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QueueSystem.Domain.Entities;
using QueueSystem.Domain.Entities.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueSystem.Domain.EntitiesConfiguration.UserConfiguration
{
    public class RoleConfiguration : IEntityTypeConfiguration<AppRole>
    {
        public void Configure(EntityTypeBuilder<AppRole> builder)
        {
            builder.HasData(
                new AppRole()
                {
                    Id=1,
                    Name = "Admin",
                    NormalizedName = "ADMIN",
                },
                new AppRole()
                {
                    Id=2,
                    Name = "User",
                    NormalizedName = "USER"
                },
                new AppRole()
                {
                    Id=3,
                    Name = "Customer",
                    NormalizedName = "CUSTOMER"
                });
        }
    }
}
