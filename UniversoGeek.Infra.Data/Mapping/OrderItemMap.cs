﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversoGeek.Infra.Data.Mapping
{
    public class OrderItemMap : IEntityTypeConfiguration<OrderItem>
    {
        public void Configure(EntityTypeBuilder<OrderItem> builder)
        {
            builder.ToTable(TableNames.TbOrderItem);
            builder.Property(oi => oi.OrderId).IsRequired();
            builder.Property(oi => oi.ProductId).IsRequired();
            builder.Property(oi => oi.ProductName).HasMaxLength(100).IsRequired();
            builder.Property(oi => oi.Amount).IsRequired();
            builder.Property(oi => oi.UnitValue).IsRequired().HasPrecision(10, 2);
            builder.Property(oi => oi.ProductImage).HasMaxLength(250);

            builder.HasOne(oi => oi.Order)
                .WithMany(o => o.OrderItems)
                .HasForeignKey(oi => oi.OrderId)
                .HasConstraintName("Fk_OrderItems_Order")
                .IsRequired();

            builder.Ignore(oi => oi.Deleted);
        }
    }
}
