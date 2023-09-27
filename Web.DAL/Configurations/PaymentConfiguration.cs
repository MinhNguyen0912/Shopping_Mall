using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Conventions.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.DAL.Entities;

namespace Web.DAL.Configurations
{
    public class PaymentConfiguration : IEntityTypeConfiguration<Payment>
    {
        public void Configure(EntityTypeBuilder<Payment> builder)
        {
            builder.ToTable("Payments");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Amount).IsRequired(true);
            builder.Property(p => p.TransactionId).IsRequired(true);
            builder.Property(p => p.TransactionDate).IsRequired(true);
            builder.Property(p => p.PaymentCode).IsRequired(true);
            builder.Property(p => p.PaymentMethod).IsRequired(true);
            builder.Property(p => p.SatusId).IsRequired(true);
            builder.Property(p => p.Fee).IsRequired(true);
            builder.Property(p => p.IsDeleted).IsRequired(true);
            builder.Property(p => p.UpdatedAt).IsRequired(false);
            builder.Property(p => p.UpdatedBy).IsRequired(false);
            builder.Property(p => p.CreatedAt).IsRequired(true);
            builder.Property(p => p.UpdatedBy).IsRequired(true);
        }
    }
}
