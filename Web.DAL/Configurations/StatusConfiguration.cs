using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.DAL.Entities;

namespace Web.DAL.Configurations
{
    public class StatusConfiguration : IEntityTypeConfiguration<Status>
    {
        public void Configure(EntityTypeBuilder<Status> builder)
        {
            builder.ToTable("Statuses");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Type).IsRequired(true);
            builder.Property(p => p.Code).IsRequired(true);
            builder.Property(p => p.Display).IsRequired(true);
            builder.Property(p => p.IsDeleted).IsRequired(true);
            builder.Property(p => p.UpdatedAt).IsRequired(false);
            builder.Property(p => p.UpdatedBy).IsRequired(false);
            builder.Property(p => p.CreatedAt).IsRequired(true);
            builder.Property(p => p.UpdatedBy).IsRequired(true);
        }
    }
}
