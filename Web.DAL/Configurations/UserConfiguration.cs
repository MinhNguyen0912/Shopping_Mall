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
    public class UserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder.ToTable("ApplicationUsers");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.IsActive).IsRequired(true);
            builder.Property(p => p.IsDeleted).IsRequired(true);
            builder.Property(p => p.LastLoginDate).IsRequired(false);
            builder.Property(p => p.Picture).IsRequired(false);
            builder.Property(p => p.Introduction).IsRequired(false).HasMaxLength(500);
            builder.Property(p => p.ReasonBlocked).IsRequired(false).HasMaxLength(255);
            builder.Property(p => p.DateOfBirth).IsRequired(true);
            builder.Property(p => p.BlockedDate).IsRequired(false);
            builder.Property(p => p.UpdatedAt).IsRequired(false);
            builder.Property(p => p.UpdatedBy).IsRequired(false);
            builder.Property(p => p.FullName).IsRequired(true).HasMaxLength(100);
            builder.Property(p => p.Address).IsRequired(true).HasMaxLength(255);
            builder.Property(p => p.CreatedAt).IsRequired(true);
            builder.Property(p => p.CreatedBy).IsRequired(true);
            builder.Property(p => p.NickName).IsRequired(false).HasMaxLength(100);
        }
    }
}
