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
    public class OrderItemConfiguration : IEntityTypeConfiguration<OrderItem>
    {
        public void Configure(EntityTypeBuilder<OrderItem> builder)
        {
            builder.ToTable("OrderItems");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Quantity).IsRequired(true);
            builder.Property(p => p.Price).IsRequired(true);
            builder.Property(p => p.OrderId).IsRequired(true);
            builder.Property(p => p.ProductId).IsRequired(true);
            builder.Property(p => p.PromotionId).IsRequired(true);
            builder.Property(p => p.IsDeleted).IsRequired(true);
            builder.Property(p => p.UpdatedAt).IsRequired(false);
            builder.Property(p => p.UpdatedBy).IsRequired(false);
            builder.Property(p => p.CreatedAt).IsRequired(true);
            builder.Property(p => p.UpdatedBy).IsRequired(true);
        }
    }
}
