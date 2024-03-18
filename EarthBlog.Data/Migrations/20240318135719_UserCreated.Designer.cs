﻿// <auto-generated />
using System;
using EarthBlog.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EarthBlog.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240318135719_UserCreated")]
    partial class UserCreated
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EarthBlog.Entity.Entities.AppRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("a50a6928-fe5b-4895-b570-ebca1fee4140"),
                            ConcurrencyStamp = "5d5c1c23-a1ad-4ff7-8305-bf9c87340fab",
                            Name = "SuperAdmin",
                            NormalizedName = "SUPERADMIN"
                        },
                        new
                        {
                            Id = new Guid("811b6955-ab4d-4c07-9887-44905e5cdd74"),
                            ConcurrencyStamp = "61cea6e4-16fe-4751-83ff-bf637567cea0",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = new Guid("b1680377-ab78-4596-9e95-05027562f714"),
                            ConcurrencyStamp = "e4a75542-b23e-4a36-aaa5-22a4b5d8c5ff",
                            Name = "User",
                            NormalizedName = "USER"
                        });
                });

            modelBuilder.Entity("EarthBlog.Entity.Entities.AppRoleClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("EarthBlog.Entity.Entities.AppUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("8de8558e-a1f2-40c2-8481-770d75a8f88a"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "64e816f0-5055-47ad-9c10-d4c4da2a9be0",
                            Email = "admin@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "Admin",
                            LastName = "User",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@GMAIL.COM",
                            NormalizedUserName = "ADMIN@GMAIL.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEL4vmLcy7I9S2okb1jBbivBdC44sY6pjgzCkk6tmShxi1COtxWW5bB0l2JzU5Pjy/g==",
                            PhoneNumber = "+905533566666",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "9907db32-7b58-41ac-95a5-026cf8789316",
                            TwoFactorEnabled = false,
                            UserName = "admin@gmail.com"
                        },
                        new
                        {
                            Id = new Guid("66d01b81-288c-44aa-a8b1-b021d7041af5"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "979b732c-3f3d-4f0c-bc8d-1e06032d3b48",
                            Email = "superadmin@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Burak",
                            LastName = "Cevizli",
                            LockoutEnabled = false,
                            NormalizedEmail = "SUPERADMIN@GMAIL.COM",
                            NormalizedUserName = "SUPERADMIN@GMAIL.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAENjtLWIY+qqrrh8chNXKnic49xZ9gMcdAPdQTBptm1w9fvszlB7zPZ7meINtIFJJ1g==",
                            PhoneNumber = "+905533454545",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "6a1f5277-9ed9-4d1d-b942-31dce3767c58",
                            TwoFactorEnabled = false,
                            UserName = "superadmin@gmail.com"
                        });
                });

            modelBuilder.Entity("EarthBlog.Entity.Entities.AppUserClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("EarthBlog.Entity.Entities.AppUserLogin", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("EarthBlog.Entity.Entities.AppUserRole", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = new Guid("66d01b81-288c-44aa-a8b1-b021d7041af5"),
                            RoleId = new Guid("a50a6928-fe5b-4895-b570-ebca1fee4140")
                        },
                        new
                        {
                            UserId = new Guid("8de8558e-a1f2-40c2-8481-770d75a8f88a"),
                            RoleId = new Guid("811b6955-ab4d-4c07-9887-44905e5cdd74")
                        });
                });

            modelBuilder.Entity("EarthBlog.Entity.Entities.AppUserToken", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("EarthBlog.Entity.Entities.Article", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("ImageId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ViewCount")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ImageId");

                    b.ToTable("Articles");

                    b.HasData(
                        new
                        {
                            Id = new Guid("b99acc67-61c1-431c-b6ec-2dcaa8a05a20"),
                            CategoryId = new Guid("d8f762d7-d360-4573-a717-eacafef67266"),
                            Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed ac justo eget leo fringilla suscipit. Nullam vitae sapien vel ligula ultrices fermentum. Phasellus sollicitudin, nisi a fermentum convallis, eros dui varius ex, sed hendrerit ligula nisi eget magna. Integer posuere nibh at sem faucibus, in accumsan quam efficitur. Vivamus nec mi nec dolor fermentum aliquam. Duis ullamcorper feugiat magna, a suscipit metus mattis nec. Quisque sed velit quis nisi convallis feugiat nec eu lacus. Proin id ipsum sit amet magna consequat aliquet. Ut viverra magna in erat laoreet, ac lacinia ipsum luctus. Nam sodales convallis aliquam. Morbi in libero urna. Fusce sed est a nulla tincidunt tempus non eu odio. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Integer efficitur turpis a nisi fringilla, at vestibulum lorem cursus. Suspendisse potenti. Nulla facilisi. Vivamus ac dui non odio aliquam gravida.",
                            CreatedBy = "Admin Test",
                            CreatedDate = new DateTime(2024, 3, 18, 16, 57, 17, 745, DateTimeKind.Local).AddTicks(6656),
                            ImageId = new Guid("24760b47-f5ae-4cf6-bfee-b17fcab0e9f1"),
                            IsDeleted = false,
                            Title = "Asp.net Core Deneme Makalesi 1",
                            ViewCount = 15
                        },
                        new
                        {
                            Id = new Guid("48407d35-45cb-4e4c-8cda-d7244a486390"),
                            CategoryId = new Guid("fd18e57b-2b39-4768-a1f3-2300c7c2069a"),
                            Content = "Visual Studio Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed ac justo eget leo fringilla suscipit. Nullam vitae sapien vel ligula ultrices fermentum. Phasellus sollicitudin, nisi a fermentum convallis, eros dui varius ex, sed hendrerit ligula nisi eget magna. Integer posuere nibh at sem faucibus, in accumsan quam efficitur. Vivamus nec mi nec dolor fermentum aliquam. Duis ullamcorper feugiat magna, a suscipit metus mattis nec. Quisque sed velit quis nisi convallis feugiat nec eu lacus. Proin id ipsum sit amet magna consequat aliquet. Ut viverra magna in erat laoreet, ac lacinia ipsum luctus. Nam sodales convallis aliquam. Morbi in libero urna. Fusce sed est a nulla tincidunt tempus non eu odio. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Integer efficitur turpis a nisi fringilla, at vestibulum lorem cursus. Suspendisse potenti. Nulla facilisi. Vivamus ac dui non odio aliquam gravida.",
                            CreatedBy = "Admin Test",
                            CreatedDate = new DateTime(2024, 3, 18, 16, 57, 17, 745, DateTimeKind.Local).AddTicks(6663),
                            ImageId = new Guid("3bd041f8-a798-4b61-adc3-669191a54d9b"),
                            IsDeleted = false,
                            Title = "Visual Studio Deneme Makalesi 1",
                            ViewCount = 15
                        });
                });

            modelBuilder.Entity("EarthBlog.Entity.Entities.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = new Guid("d8f762d7-d360-4573-a717-eacafef67266"),
                            CreatedBy = "Admin Test",
                            CreatedDate = new DateTime(2024, 3, 18, 16, 57, 17, 745, DateTimeKind.Local).AddTicks(7809),
                            IsDeleted = false,
                            Name = "ASP.NET CORE"
                        },
                        new
                        {
                            Id = new Guid("fd18e57b-2b39-4768-a1f3-2300c7c2069a"),
                            CreatedBy = "Admin Test",
                            CreatedDate = new DateTime(2024, 3, 18, 16, 57, 17, 745, DateTimeKind.Local).AddTicks(7831),
                            IsDeleted = false,
                            Name = "Visual Studio 2024"
                        });
                });

            modelBuilder.Entity("EarthBlog.Entity.Entities.Image", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FileType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Images");

                    b.HasData(
                        new
                        {
                            Id = new Guid("24760b47-f5ae-4cf6-bfee-b17fcab0e9f1"),
                            CreatedBy = "Admin Test",
                            CreatedDate = new DateTime(2024, 3, 18, 16, 57, 17, 745, DateTimeKind.Local).AddTicks(8745),
                            FileName = "images/testimage",
                            FileType = "jpg",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = new Guid("3bd041f8-a798-4b61-adc3-669191a54d9b"),
                            CreatedBy = "Admin Test",
                            CreatedDate = new DateTime(2024, 3, 18, 16, 57, 17, 745, DateTimeKind.Local).AddTicks(8748),
                            FileName = "images/vstest",
                            FileType = "png",
                            IsDeleted = false
                        });
                });

            modelBuilder.Entity("EarthBlog.Entity.Entities.AppRoleClaim", b =>
                {
                    b.HasOne("EarthBlog.Entity.Entities.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EarthBlog.Entity.Entities.AppUserClaim", b =>
                {
                    b.HasOne("EarthBlog.Entity.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EarthBlog.Entity.Entities.AppUserLogin", b =>
                {
                    b.HasOne("EarthBlog.Entity.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EarthBlog.Entity.Entities.AppUserRole", b =>
                {
                    b.HasOne("EarthBlog.Entity.Entities.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EarthBlog.Entity.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EarthBlog.Entity.Entities.AppUserToken", b =>
                {
                    b.HasOne("EarthBlog.Entity.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EarthBlog.Entity.Entities.Article", b =>
                {
                    b.HasOne("EarthBlog.Entity.Entities.Category", "Category")
                        .WithMany("Articles")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EarthBlog.Entity.Entities.Image", "Image")
                        .WithMany("Articles")
                        .HasForeignKey("ImageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Image");
                });

            modelBuilder.Entity("EarthBlog.Entity.Entities.Category", b =>
                {
                    b.Navigation("Articles");
                });

            modelBuilder.Entity("EarthBlog.Entity.Entities.Image", b =>
                {
                    b.Navigation("Articles");
                });
#pragma warning restore 612, 618
        }
    }
}
