using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QueueSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueSystem.Domain.EntitiesConfiguration
{
    public class StatusConfiguration : IEntityTypeConfiguration<Status>
    {
        public void Configure(EntityTypeBuilder<Status> builder)
        {
            builder.HasData(
                new Status()
                {
                    Id = 1,
                    Title = "Waiting",
                    AddDate = DateTime.Now,
                    DeletedDate = null,
                    UpdateDate = null
                }
                ,
                new Status()
                {
                    Id = 2,
                    Title = "Called",
                    AddDate = DateTime.Now,
                    DeletedDate = null,
                    UpdateDate = null
                },

                new Status()
                {
                    Id = 3,
                    Title = "Serving",
                    AddDate = DateTime.Now,
                    DeletedDate = null,
                    UpdateDate = null
                },
                new Status()
                {
                    Id = 4,
                    Title = "Cancelled",
                    AddDate = DateTime.Now,
                    DeletedDate = null,
                    UpdateDate = null
                }, new Status()
                {
                    Id = 5,
                    Title = "Completed",
                    AddDate = DateTime.Now,
                    DeletedDate = null,
                    UpdateDate = null
                },
                new Status()
                {
                    Id = 6,
                    Title = "Expired",
                    AddDate = DateTime.Now,
                    DeletedDate = null,
                    UpdateDate = null
                },
                new Status()
                {
                    Id = 7,
                    Title = "Recalled",
                    AddDate = DateTime.Now,
                    DeletedDate = null,
                    UpdateDate = null
                }
            );
        }
    }
}
