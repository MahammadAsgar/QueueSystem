using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QueueSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace QueueSystem.Domain.EntitiesConfiguration
{
    public class PriorityConfiguration : IEntityTypeConfiguration<Priority>
    {
        public void Configure(EntityTypeBuilder<Priority> builder)
        {
            builder.HasData(
                new Priority()
                {
                    Id = 1,
                    Code = "P1",
                    Title = "Critical",
                    AddDate = DateTime.Now,
                    DeletedDate = null,
                    UpdateDate = null
                },
                new Priority()
                {
                    Id = 2,
                    Code = "P2",
                    Title = "High",
                    AddDate = DateTime.Now,
                    DeletedDate = null,
                    UpdateDate = null
                },
                new Priority()
                {
                    Id = 3,
                    Code = "P3",
                    Title = "Medium",
                    AddDate = DateTime.Now,
                    DeletedDate = null,
                    UpdateDate = null
                },
                new Priority()
                {
                    Id = 4,
                    Code = "P4",
                    Title = "Low",
                    AddDate = DateTime.Now,
                    DeletedDate = null,
                    UpdateDate = null
                });
        }
    }
}
