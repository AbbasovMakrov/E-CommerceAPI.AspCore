﻿// <auto-generated />
using System;
using E_Commerce.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace E_Commerce.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20201026114509_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("E_Commerce.Data.Entities.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("E_Commerce.Data.Entities.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("E_Commerce.Data.Entities.OrderProduct", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("OrderId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderProducts");
                });

            modelBuilder.Entity("E_Commerce.Data.Entities.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("UserId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("E_Commerce.Data.Entities.RevokedToken", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("RevokedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("RevokedTokens");
                });

            modelBuilder.Entity("E_Commerce.Data.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("65d1e165-f31e-3ac0-194f-82ecbed83b36"),
                            CreatedAt = new DateTime(2020, 10, 26, 14, 45, 8, 363, DateTimeKind.Local).AddTicks(1731),
                            Email = "matt87@yahoo.com",
                            Name = "Matt Krajcik",
                            Password = "$2y$11$ZvZR41.QNYU4qAznY.y.ZuvPUmMMSxSnRhxLYRJvhRU0rWYyYffA6",
                            Role = "Admin"
                        },
                        new
                        {
                            Id = new Guid("5803973c-76d1-7e50-93e1-e03619650fdc"),
                            CreatedAt = new DateTime(2020, 10, 26, 14, 45, 8, 363, DateTimeKind.Local).AddTicks(1731),
                            Email = "dawn_schmeler@yahoo.com",
                            Name = "Dawn Schmeler",
                            Password = "$2y$11$ZvZR41.QNYU4qAznY.y.ZuvPUmMMSxSnRhxLYRJvhRU0rWYyYffA6",
                            Role = "User"
                        },
                        new
                        {
                            Id = new Guid("6f7f640e-9c15-2538-bb2a-449621ba548c"),
                            CreatedAt = new DateTime(2020, 10, 26, 14, 45, 8, 363, DateTimeKind.Local).AddTicks(1731),
                            Email = "laurence25@yahoo.com",
                            Name = "Laurence Mann",
                            Password = "$2y$11$ZvZR41.QNYU4qAznY.y.ZuvPUmMMSxSnRhxLYRJvhRU0rWYyYffA6",
                            Role = "Admin"
                        },
                        new
                        {
                            Id = new Guid("06002bdc-c8f0-b4be-2c04-7cb892fd3837"),
                            CreatedAt = new DateTime(2020, 10, 26, 14, 45, 8, 363, DateTimeKind.Local).AddTicks(1731),
                            Email = "brittany.satterfield96@gmail.com",
                            Name = "Brittany Satterfield",
                            Password = "$2y$11$ZvZR41.QNYU4qAznY.y.ZuvPUmMMSxSnRhxLYRJvhRU0rWYyYffA6",
                            Role = "User"
                        },
                        new
                        {
                            Id = new Guid("10d8bdc1-f32d-5916-bc34-998e88e1cf6d"),
                            CreatedAt = new DateTime(2020, 10, 26, 14, 45, 8, 363, DateTimeKind.Local).AddTicks(1731),
                            Email = "lindsay_green31@yahoo.com",
                            Name = "Lindsay Green",
                            Password = "$2y$11$ZvZR41.QNYU4qAznY.y.ZuvPUmMMSxSnRhxLYRJvhRU0rWYyYffA6",
                            Role = "Admin"
                        },
                        new
                        {
                            Id = new Guid("c2f4da08-3b43-d854-a828-6d4bcf26208b"),
                            CreatedAt = new DateTime(2020, 10, 26, 14, 45, 8, 363, DateTimeKind.Local).AddTicks(1731),
                            Email = "oliver81@gmail.com",
                            Name = "Oliver Emmerich",
                            Password = "$2y$11$ZvZR41.QNYU4qAznY.y.ZuvPUmMMSxSnRhxLYRJvhRU0rWYyYffA6",
                            Role = "Admin"
                        },
                        new
                        {
                            Id = new Guid("b9b82323-7c88-ec3f-6820-a1ee5bbc1187"),
                            CreatedAt = new DateTime(2020, 10, 26, 14, 45, 8, 363, DateTimeKind.Local).AddTicks(1731),
                            Email = "phillip_kuvalis37@gmail.com",
                            Name = "Phillip Kuvalis",
                            Password = "$2y$11$ZvZR41.QNYU4qAznY.y.ZuvPUmMMSxSnRhxLYRJvhRU0rWYyYffA6",
                            Role = "Admin"
                        },
                        new
                        {
                            Id = new Guid("89ea143a-99f7-2067-cbfa-a7d517af5b35"),
                            CreatedAt = new DateTime(2020, 10, 26, 14, 45, 8, 363, DateTimeKind.Local).AddTicks(1731),
                            Email = "ethel_cassin52@yahoo.com",
                            Name = "Ethel Cassin",
                            Password = "$2y$11$ZvZR41.QNYU4qAznY.y.ZuvPUmMMSxSnRhxLYRJvhRU0rWYyYffA6",
                            Role = "User"
                        },
                        new
                        {
                            Id = new Guid("bca9565b-e066-5055-d79a-56bd8a7b6fb9"),
                            CreatedAt = new DateTime(2020, 10, 26, 14, 45, 8, 363, DateTimeKind.Local).AddTicks(1731),
                            Email = "lula_schoen@gmail.com",
                            Name = "Lula Schoen",
                            Password = "$2y$11$ZvZR41.QNYU4qAznY.y.ZuvPUmMMSxSnRhxLYRJvhRU0rWYyYffA6",
                            Role = "Admin"
                        },
                        new
                        {
                            Id = new Guid("3f72465c-ddb6-1555-4c3f-da41a8f1b368"),
                            CreatedAt = new DateTime(2020, 10, 26, 14, 45, 8, 363, DateTimeKind.Local).AddTicks(1731),
                            Email = "loretta_goyette78@gmail.com",
                            Name = "Loretta Goyette",
                            Password = "$2y$11$ZvZR41.QNYU4qAznY.y.ZuvPUmMMSxSnRhxLYRJvhRU0rWYyYffA6",
                            Role = "Admin"
                        },
                        new
                        {
                            Id = new Guid("e7678337-3576-596c-392d-f5ed09ac615b"),
                            CreatedAt = new DateTime(2020, 10, 26, 14, 45, 8, 363, DateTimeKind.Local).AddTicks(1731),
                            Email = "olivia_gleason@yahoo.com",
                            Name = "Olivia Gleason",
                            Password = "$2y$11$ZvZR41.QNYU4qAznY.y.ZuvPUmMMSxSnRhxLYRJvhRU0rWYyYffA6",
                            Role = "Admin"
                        },
                        new
                        {
                            Id = new Guid("6eaf0aff-937f-babc-3581-24f58c031544"),
                            CreatedAt = new DateTime(2020, 10, 26, 14, 45, 8, 363, DateTimeKind.Local).AddTicks(1731),
                            Email = "fred_leuschke@yahoo.com",
                            Name = "Fred Leuschke",
                            Password = "$2y$11$ZvZR41.QNYU4qAznY.y.ZuvPUmMMSxSnRhxLYRJvhRU0rWYyYffA6",
                            Role = "User"
                        },
                        new
                        {
                            Id = new Guid("27caf944-31c9-67aa-b9cd-5f5fbd2b49e9"),
                            CreatedAt = new DateTime(2020, 10, 26, 14, 45, 8, 363, DateTimeKind.Local).AddTicks(1731),
                            Email = "shane22@yahoo.com",
                            Name = "Shane Upton",
                            Password = "$2y$11$ZvZR41.QNYU4qAznY.y.ZuvPUmMMSxSnRhxLYRJvhRU0rWYyYffA6",
                            Role = "User"
                        },
                        new
                        {
                            Id = new Guid("841f4f8e-a5cb-d785-1fa2-781436599cb5"),
                            CreatedAt = new DateTime(2020, 10, 26, 14, 45, 8, 363, DateTimeKind.Local).AddTicks(1731),
                            Email = "cedric.huel@hotmail.com",
                            Name = "Cedric Huel",
                            Password = "$2y$11$ZvZR41.QNYU4qAznY.y.ZuvPUmMMSxSnRhxLYRJvhRU0rWYyYffA6",
                            Role = "User"
                        },
                        new
                        {
                            Id = new Guid("f65bb821-ef55-a5e1-8d5b-45031f076137"),
                            CreatedAt = new DateTime(2020, 10, 26, 14, 45, 8, 363, DateTimeKind.Local).AddTicks(1731),
                            Email = "alice.davis93@hotmail.com",
                            Name = "Alice Davis",
                            Password = "$2y$11$ZvZR41.QNYU4qAznY.y.ZuvPUmMMSxSnRhxLYRJvhRU0rWYyYffA6",
                            Role = "User"
                        },
                        new
                        {
                            Id = new Guid("0090d917-15a5-d394-da0d-c3b69dc91d1d"),
                            CreatedAt = new DateTime(2020, 10, 26, 14, 45, 8, 363, DateTimeKind.Local).AddTicks(1731),
                            Email = "anita.lind51@hotmail.com",
                            Name = "Anita Lind",
                            Password = "$2y$11$ZvZR41.QNYU4qAznY.y.ZuvPUmMMSxSnRhxLYRJvhRU0rWYyYffA6",
                            Role = "User"
                        },
                        new
                        {
                            Id = new Guid("af12ea5f-7205-02ff-42b9-5a2f5ca84dd3"),
                            CreatedAt = new DateTime(2020, 10, 26, 14, 45, 8, 363, DateTimeKind.Local).AddTicks(1731),
                            Email = "kay39@hotmail.com",
                            Name = "Kay Marquardt",
                            Password = "$2y$11$ZvZR41.QNYU4qAznY.y.ZuvPUmMMSxSnRhxLYRJvhRU0rWYyYffA6",
                            Role = "User"
                        },
                        new
                        {
                            Id = new Guid("ef448a02-14df-0e2f-b5ed-b258d7e9d1a6"),
                            CreatedAt = new DateTime(2020, 10, 26, 14, 45, 8, 363, DateTimeKind.Local).AddTicks(1731),
                            Email = "deborah_mante@yahoo.com",
                            Name = "Deborah Mante",
                            Password = "$2y$11$ZvZR41.QNYU4qAznY.y.ZuvPUmMMSxSnRhxLYRJvhRU0rWYyYffA6",
                            Role = "Admin"
                        },
                        new
                        {
                            Id = new Guid("f87e20a0-3745-bd6d-3fd7-f2f38470f4ca"),
                            CreatedAt = new DateTime(2020, 10, 26, 14, 45, 8, 363, DateTimeKind.Local).AddTicks(1731),
                            Email = "olga_dach@yahoo.com",
                            Name = "Olga Dach",
                            Password = "$2y$11$ZvZR41.QNYU4qAznY.y.ZuvPUmMMSxSnRhxLYRJvhRU0rWYyYffA6",
                            Role = "Admin"
                        },
                        new
                        {
                            Id = new Guid("c6d52796-3dfd-e80a-b4fd-9e46a0149236"),
                            CreatedAt = new DateTime(2020, 10, 26, 14, 45, 8, 363, DateTimeKind.Local).AddTicks(1731),
                            Email = "darren.tromp@gmail.com",
                            Name = "Darren Tromp",
                            Password = "$2y$11$ZvZR41.QNYU4qAznY.y.ZuvPUmMMSxSnRhxLYRJvhRU0rWYyYffA6",
                            Role = "Admin"
                        });
                });

            modelBuilder.Entity("E_Commerce.Data.Entities.Order", b =>
                {
                    b.HasOne("E_Commerce.Data.Entities.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("E_Commerce.Data.Entities.OrderProduct", b =>
                {
                    b.HasOne("E_Commerce.Data.Entities.Order", "Order")
                        .WithMany("Products")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("E_Commerce.Data.Entities.Product", "Product")
                        .WithMany("Orders")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("E_Commerce.Data.Entities.Product", b =>
                {
                    b.HasOne("E_Commerce.Data.Entities.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("E_Commerce.Data.Entities.User", "User")
                        .WithMany("Products")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
