﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using UniversoGeek.Infra.Data.Context;

namespace UniversoGeek.Infra.Data.Migrations
{
    [DbContext(typeof(UniversoGeekDbContext))]
    partial class XStoreDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("UniversoGeek.Domain.Entities.Address", b =>
            {
                b.Property<Guid>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("uniqueidentifier");

                b.Property<string>("City")
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnType("nvarchar(50)");

                b.Property<string>("Complement")
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnType("nvarchar(200)");

                b.Property<DateTimeOffset>("CreatedAt")
                    .HasColumnType("datetimeoffset");

                b.Property<string>("Neighborhood")
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnType("nvarchar(100)");

                b.Property<string>("Number")
                    .IsRequired()
                    .HasMaxLength(5)
                    .HasColumnType("nvarchar(5)");

                b.Property<string>("PostalCode")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("State")
                    .IsRequired()
                    .HasMaxLength(2)
                    .HasColumnType("nvarchar(2)");

                b.Property<string>("Street")
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnType("nvarchar(200)");

                b.Property<DateTimeOffset>("UpdatedAt")
                    .HasColumnType("datetimeoffset");

                b.HasKey("Id");

                b.ToTable("xs_Address", (string)null);
            });

            modelBuilder.Entity("UniversoGeek.Domain.Entities.Client", b =>
            {
                b.Property<Guid>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("uniqueidentifier");

                b.Property<bool>("Active")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("bit")
                    .HasDefaultValue(true);

                b.Property<Guid>("AddressId")
                    .HasColumnType("uniqueidentifier");

                b.Property<string>("Cpf")
                    .IsRequired()
                    .HasMaxLength(14)
                    .HasColumnType("nvarchar(14)");

                b.Property<DateTimeOffset>("CreatedAt")
                    .HasColumnType("datetimeoffset");

                b.Property<string>("Email")
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnType("nvarchar(100)");

                b.Property<string>("Name")
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnType("nvarchar(100)");

                b.Property<DateTimeOffset>("UpdatedAt")
                    .HasColumnType("datetimeoffset");

                b.HasKey("Id");

                b.HasIndex("AddressId");

                b.ToTable("xs_Client", (string)null);
            });

            modelBuilder.Entity("UniversoGeek.Domain.Entities.Order", b =>
            {
                b.Property<Guid>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("uniqueidentifier");

                b.Property<Guid>("AddressId")
                    .HasColumnType("uniqueidentifier");

                b.Property<Guid>("ClientId")
                    .HasColumnType("uniqueidentifier");

                b.Property<string>("Code")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<DateTimeOffset>("CreatedAt")
                    .HasColumnType("datetimeoffset");

                b.Property<decimal>("Discount")
                    .HasPrecision(10, 2)
                    .HasColumnType("decimal(10,2)");

                b.Property<int>("OrderStatus")
                    .HasColumnType("int");

                b.Property<decimal>("TotalValue")
                    .HasPrecision(10, 2)
                    .HasColumnType("decimal(10,2)");

                b.Property<DateTimeOffset>("UpdatedAt")
                    .HasColumnType("datetimeoffset");

                b.Property<Guid?>("VoucherId")
                    .HasColumnType("uniqueidentifier");

                b.Property<bool>("VoucherUsed")
                    .HasColumnType("bit");

                b.HasKey("Id");

                b.HasIndex("AddressId");

                b.HasIndex("VoucherId");

                b.ToTable("xs_Order", (string)null);
            });

            modelBuilder.Entity("UniversoGeek.Domain.Entities.OrderItem", b =>
            {
                b.Property<Guid>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("uniqueidentifier");

                b.Property<int>("Amount")
                    .HasColumnType("int");

                b.Property<DateTimeOffset>("CreatedAt")
                    .HasColumnType("datetimeoffset");

                b.Property<Guid>("OrderId")
                    .HasColumnType("uniqueidentifier");

                b.Property<Guid>("ProductId")
                    .HasColumnType("uniqueidentifier");

                b.Property<string>("ProductImage")
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnType("nvarchar(250)");

                b.Property<string>("ProductName")
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnType("nvarchar(100)");

                b.Property<decimal>("UnitValue")
                    .HasPrecision(10, 2)
                    .HasColumnType("decimal(10,2)");

                b.Property<DateTimeOffset>("UpdatedAt")
                    .HasColumnType("datetimeoffset");

                b.HasKey("Id");

                b.HasIndex("OrderId");

                b.ToTable("xs_OrderItem", (string)null);
            });

            modelBuilder.Entity("UniversoGeek.Domain.Entities.Product", b =>
            {
                b.Property<Guid>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("uniqueidentifier");

                b.Property<bool>("Active")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("bit")
                    .HasDefaultValue(true);

                b.Property<DateTimeOffset>("CreatedAt")
                    .HasColumnType("datetimeoffset");

                b.Property<DateTime>("DateRegister")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("datetime2")
                    .HasDefaultValue(new DateTime(2023, 4, 19, 17, 53, 5, 704, DateTimeKind.Local).AddTicks(1043));

                b.Property<string>("Description")
                    .IsRequired()
                    .HasMaxLength(240)
                    .HasColumnType("nvarchar(240)");

                b.Property<string>("Image")
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnType("nvarchar(200)");

                b.Property<string>("Name")
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnType("nvarchar(100)");

                b.Property<decimal>("Price")
                    .HasPrecision(10, 2)
                    .HasColumnType("decimal(10,2)");

                b.Property<int>("StockQuantity")
                    .HasColumnType("int");

                b.Property<DateTimeOffset>("UpdatedAt")
                    .HasColumnType("datetimeoffset");

                b.HasKey("Id");

                b.ToTable("xs_Product", (string)null);
            });

            modelBuilder.Entity("UniversoGeek.Domain.Entities.Voucher", b =>
            {
                b.Property<Guid>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("uniqueidentifier");

                b.Property<bool>("Active")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("bit")
                    .HasDefaultValue(true);

                b.Property<int>("Amount")
                    .HasColumnType("int");

                b.Property<string>("Code")
                    .IsRequired()
                    .HasMaxLength(6)
                    .HasColumnType("nvarchar(6)");

                b.Property<DateTimeOffset>("CreatedAt")
                    .HasColumnType("datetimeoffset");

                b.Property<int>("DiscountType")
                    .HasColumnType("int");

                b.Property<decimal?>("DiscountValue")
                    .HasPrecision(10, 2)
                    .HasColumnType("decimal(10,2)");

                b.Property<DateTime>("ExpirationDate")
                    .HasColumnType("datetime2");

                b.Property<decimal?>("Percentage")
                    .HasPrecision(10, 2)
                    .HasColumnType("decimal(10,2)");

                b.Property<DateTimeOffset>("UpdatedAt")
                    .HasColumnType("datetimeoffset");

                b.Property<bool?>("Used")
                    .HasColumnType("bit");

                b.Property<DateTime?>("UsedDate")
                    .HasColumnType("datetime2");

                b.HasKey("Id");

                b.ToTable("xs_Voucher", (string)null);
            });

            modelBuilder.Entity("UniversoGeek.Domain.Entities.Client", b =>
            {
                b.HasOne("UniversoGeek.Domain.Entities.Address", "Address")
                    .WithMany()
                    .HasForeignKey("AddressId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("Address");
            });

            modelBuilder.Entity("UniversoGeek.Domain.Entities.Order", b =>
            {
                b.HasOne("UniversoGeek.Domain.Entities.Address", "Address")
                    .WithMany()
                    .HasForeignKey("AddressId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.HasOne("UniversoGeek.Domain.Entities.Voucher", "Voucher")
                    .WithMany()
                    .HasForeignKey("VoucherId");

                b.Navigation("Address");

                b.Navigation("Voucher");
            });

            modelBuilder.Entity("UniversoGeek.Domain.Entities.OrderItem", b =>
            {
                b.HasOne("UniversoGeek.Domain.Entities.Order", "Order")
                    .WithMany("OrderItems")
                    .HasForeignKey("OrderId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired()
                    .HasConstraintName("Fk_OrderItems_Order");

                b.Navigation("Order");
            });

            modelBuilder.Entity("UniversoGeek.Domain.Entities.Order", b =>
            {
                b.Navigation("OrderItems");
            });
#pragma warning restore 612, 618
        }
    }
}