﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TestDAL.Models;

namespace TestDAL.Migrations
{
    [DbContext(typeof(NovoBITestDBContext))]
    [Migration("20221006160044_Seed43werre")]
    partial class Seed43werre
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TestDAL.Models.BookOrders", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.HasIndex("OrderId");

                    b.ToTable("BookOrders");
                });

            modelBuilder.Entity("TestDAL.Models.BookTypes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BookTypeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("BookTypes");
                });

            modelBuilder.Entity("TestDAL.Models.Books", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Barcode")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("BookTypeId")
                        .HasColumnType("int");

                    b.Property<string>("ExtraData")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("PageCount")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18, 0)");

                    b.HasKey("Id");

                    b.HasIndex("BookTypeId");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("TestDAL.Models.DiscContents", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DiscContentName")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("DiscContents");
                });

            modelBuilder.Entity("TestDAL.Models.DiscOrders", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DiscId")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DiscId");

                    b.HasIndex("OrderId");

                    b.ToTable("DiscOrders");
                });

            modelBuilder.Entity("TestDAL.Models.DiscTypes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DiscTypeName")
                        .HasColumnType("nchar(3)")
                        .IsFixedLength(true)
                        .HasMaxLength(3);

                    b.HasKey("Id");

                    b.ToTable("DiscTypes");
                });

            modelBuilder.Entity("TestDAL.Models.Discs", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DiscContentId")
                        .HasColumnType("int");

                    b.Property<int>("DiscTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("DiscContentId");

                    b.HasIndex("DiscTypeId");

                    b.ToTable("Discs");
                });

            modelBuilder.Entity("TestDAL.Models.OrderStatuses", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("OrderStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)")
                        .HasMaxLength(25);

                    b.HasKey("Id");

                    b.ToTable("OrderStatuses");
                });

            modelBuilder.Entity("TestDAL.Models.Orders", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClientEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<DateTime>("CreateDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<int>("OrderStatusId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime");

                    b.HasKey("Id");

                    b.HasIndex("OrderStatusId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("TestDAL.Models.BookOrders", b =>
                {
                    b.HasOne("TestDAL.Models.Books", "Book")
                        .WithMany("BookOrders")
                        .HasForeignKey("BookId")
                        .HasConstraintName("FK_BookOrders_Books")
                        .IsRequired();

                    b.HasOne("TestDAL.Models.Orders", "Order")
                        .WithMany("BookOrders")
                        .HasForeignKey("OrderId")
                        .HasConstraintName("FK_BookOrders_Orders")
                        .IsRequired();
                });

            modelBuilder.Entity("TestDAL.Models.Books", b =>
                {
                    b.HasOne("TestDAL.Models.BookTypes", "BookType")
                        .WithMany("Books")
                        .HasForeignKey("BookTypeId")
                        .HasConstraintName("FK_Books_BookTypes")
                        .IsRequired();
                });

            modelBuilder.Entity("TestDAL.Models.DiscOrders", b =>
                {
                    b.HasOne("TestDAL.Models.Discs", "Disc")
                        .WithMany("DiscOrders")
                        .HasForeignKey("DiscId")
                        .HasConstraintName("FK_DiscOrders_Discs")
                        .IsRequired();

                    b.HasOne("TestDAL.Models.Orders", "Order")
                        .WithMany("DiscOrders")
                        .HasForeignKey("OrderId")
                        .HasConstraintName("FK_DiscOrders_Orders")
                        .IsRequired();
                });

            modelBuilder.Entity("TestDAL.Models.Discs", b =>
                {
                    b.HasOne("TestDAL.Models.DiscContents", "DiscContent")
                        .WithMany("Discs")
                        .HasForeignKey("DiscContentId")
                        .HasConstraintName("FK_Discs_DiscContents")
                        .IsRequired();

                    b.HasOne("TestDAL.Models.DiscTypes", "DiscType")
                        .WithMany("Discs")
                        .HasForeignKey("DiscTypeId")
                        .HasConstraintName("FK_Discs_DiscTypes")
                        .IsRequired();
                });

            modelBuilder.Entity("TestDAL.Models.Orders", b =>
                {
                    b.HasOne("TestDAL.Models.OrderStatuses", "OrderStatus")
                        .WithMany("Orders")
                        .HasForeignKey("OrderStatusId")
                        .HasConstraintName("FK_Orders_OrdersStatuses")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
