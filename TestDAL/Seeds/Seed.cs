using Microsoft.EntityFrameworkCore;
using System;
using TestDAL.Models;
using System.Text.Json;

namespace TestDAL.Seeds
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DiscTypes>().HasData(
                new DiscTypes
                {
                    Id = 1,
                    DiscTypeName = "CD"
                },
                new DiscTypes
                {
                    Id = 2,
                    DiscTypeName = "DVD"
                });

            modelBuilder.Entity<DiscContents>().HasData(
                new DiscContents
                {
                    Id = 1,
                    DiscContentName = "Music"
                },
                new DiscContents
                {
                    Id = 2,
                    DiscContentName = "Video"
                },
                new DiscContents
                {
                    Id = 3,
                    DiscContentName = "Software"
                });

            modelBuilder.Entity<BookTypes>().HasData(
                new BookTypes
                {
                    Id = 1,
                    BookTypeName = "Software"
                },
                new BookTypes
                {
                    Id = 2,
                    BookTypeName = "Cooking"
                },
                new BookTypes
                {
                    Id = 3,
                    BookTypeName = "Esoterica"
                });

            modelBuilder.Entity<Discs>().HasData(
                new Discs
                {
                    Id = 1,
                    DiscContentId = 1,
                    DiscTypeId = 1,
                    Name = "Marlyn Manson",
                    Barcode = Guid.NewGuid().ToString(),
                    Price = 34
                }, new Discs
                {
                    Id = 2,
                    DiscContentId = 1,
                    DiscTypeId = 2,
                    Name = "RHCP 1996",
                    Barcode = Guid.NewGuid().ToString(),
                    Price = 34
                }, new Discs
                {
                    Id = 3,
                    DiscContentId = 1,
                    DiscTypeId = 2,
                    Name = "OOP Principles",
                    Barcode = Guid.NewGuid().ToString(),
                    Price = 34
                },
                new Discs
                {
                    Id = 4,
                    DiscContentId = 1,
                    DiscTypeId = 2,
                    Name = "ACDC",
                    Barcode = Guid.NewGuid().ToString(),
                    Price = 34
                }, new Discs
                {
                    Id = 5,
                    DiscContentId = 2,
                    DiscTypeId = 2,
                    Name = "National Geografic",
                    Barcode = Guid.NewGuid().ToString(),
                    Price = 34
                },
                new Discs
                {
                    Id = 6,
                    DiscContentId = 3,
                    DiscTypeId = 2,
                    Name = "CQRS Principles",
                    Barcode = Guid.NewGuid().ToString(),
                    Price = 34
                });
            modelBuilder.Entity<Books>().HasData(
                new Books
                {
                    Id = 1,
                    Barcode = new Guid().ToString(),
                    BookTypeId = 1,
                    Name = "Domain-Driven Design",
                    ExtraData = JsonSerializer.Serialize(new ExtraData { Text = "Programming language", Value = "C#" }),
                    PageCount = 123,
                    Price = 12

                },
                new Books
                {
                    Id = 2,
                    Barcode = new Guid().ToString(),
                    BookTypeId = 1,
                    Name = "Scrum Deveploment",
                    ExtraData = JsonSerializer.Serialize(new ExtraData { Text = "Programming language", Value = "Java" }),
                    PageCount = 343,
                    Price = 1442

                },
                new Books
                {
                    Id = 3,
                    Barcode = new Guid().ToString(),
                    BookTypeId = 1,
                    Name = "Software Management",
                    ExtraData = JsonSerializer.Serialize(new ExtraData { Text = "Programming language", Value = "Haskell" }),
                    PageCount = 343,
                    Price = 1442

                },
                new Books
                {
                    Id = 4,
                    Barcode = new Guid().ToString(),
                    BookTypeId = 2,
                    Name = "Receipts of pie",
                    ExtraData = JsonSerializer.Serialize(new ExtraData { Text = "Basic ingridient", Value = "Applles" }),
                    PageCount = 545,
                    Price = 6545

                },
                new Books
                {
                    Id = 5,
                    Barcode = new Guid().ToString(),
                    BookTypeId = 3,
                    Name = "Greate misteries",
                    ExtraData = JsonSerializer.Serialize(new ExtraData { Text = "Age Rectriction", Value = "18" }),
                    PageCount = 545,
                    Price = 6545

                },
                new Books
                {
                    Id = 6,
                    Barcode = new Guid().ToString(),
                    BookTypeId = 3,
                    Name = "History of esoterica",
                    ExtraData = JsonSerializer.Serialize(new ExtraData { Text = "", Value = "" }),
                    PageCount = 545,
                    Price = 6545

                });
            modelBuilder.Entity<OrderStatuses>().HasData(
                new OrderStatuses
                {
                    Id = 1,
                    OrderStatus = "New"
                },
                new OrderStatuses
                {
                    Id = 2,
                    OrderStatus = "Pending"
                },
                new OrderStatuses
                {
                    Id = 3,
                    OrderStatus = "Executing"
                },
                new OrderStatuses
                {
                    Id = 4,
                    OrderStatus = "Done"
                });
            modelBuilder.Entity<Orders>().HasData(
                new Orders
                {
                    Id = 1,
                    ClientEmail = "ooe@error.com",
                    CreateDate = DateTime.Now,
                    OrderStatusId = 1,
                },
                new Orders
                {
                    Id = 2,
                    ClientEmail = "oo1@bugs.com",
                    CreateDate = DateTime.Now,
                    OrderStatusId = 2,
                },
                new Orders
                {
                    Id = 3,
                    ClientEmail = "memory@leaks.com",
                    CreateDate = DateTime.Now,
                    OrderStatusId = 3,
                });
            modelBuilder.Entity<BookOrders>().HasData(
                new BookOrders
                {
                    Id = 1,
                    OrderId = 1,
                    BookId = 1
                },
                new BookOrders
                {
                    Id = 2,
                    OrderId = 1,
                    BookId = 3
                },
                new BookOrders
                {
                    Id = 3,
                    OrderId = 2,
                    BookId = 3
                },
                new BookOrders
                {
                    Id = 4,
                    OrderId = 3,
                    BookId = 4
                },
                new BookOrders
                {
                    Id = 5,
                    OrderId = 2,
                    BookId = 5
                });
            modelBuilder.Entity<DiscOrders>().HasData(
                new DiscOrders
                {
                    Id = 1,
                    OrderId = 1,
                    DiscId = 2,
                },
                new DiscOrders
                {
                    Id = 2,
                    OrderId = 2,
                    DiscId = 3,
                },
                new DiscOrders
                {
                    Id = 3,
                    OrderId = 3,
                    DiscId = 4,
                },
                new DiscOrders
                {
                    Id = 4,
                    OrderId = 2,
                    DiscId = 3,
                },
                new DiscOrders
                {
                    Id = 5,
                    OrderId = 1,
                    DiscId = 5,
                });
        }
    }
}
