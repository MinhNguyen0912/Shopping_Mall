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
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("Orders");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Code).IsRequired(true);
            builder.Property(p => p.CustomerName).IsRequired(false).HasMaxLength(100);
            builder.Property(p => p.Address).IsRequired(false).HasMaxLength(255);
            builder.Property(p => p.PhoneNumber).IsRequired(false).HasMaxLength(100);
            builder.Property(p => p.TotalAmount).IsRequired(true);
            builder.Property(p => p.Note).IsRequired(false).HasMaxLength(255);
            builder.Property(p => p.CancelReason).IsRequired(false).HasMaxLength(255);
            builder.Property(p => p.IsDelete).IsRequired(true);
            builder.Property(p => p.StatusId).IsRequired(true);
            builder.Property(p => p.PaymentId).IsRequired(true);
            builder.Property(p => p.UpdatedAt).IsRequired(false);
            builder.Property(p => p.UpdatedBy).IsRequired(false);
            builder.Property(p => p.CreatedAt).IsRequired(true);
            builder.Property(p => p.UpdatedBy).IsRequired(true);
        }
    }
}
