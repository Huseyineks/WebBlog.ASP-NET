﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebBlog.DataAccesLayer.Data;

#nullable disable

namespace WebBlog.DataAccesLayer.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240326134909_areyouthere")]
    partial class areyouthere
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0-preview.2.24128.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebBlog.Entitiy.Entities.AppUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("createdAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("email");

                    b.Property<string>("firstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("first_name");

                    b.Property<string>("lastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("last_name");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("password");

                    b.HasKey("Id");

                    b.ToTable("AppUsers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            createdAt = new DateTime(2024, 3, 26, 16, 49, 9, 422, DateTimeKind.Local).AddTicks(1679),
                            email = "erhan",
                            firstName = "sa",
                            lastName = "Turker1231",
                            password = "serdar"
                        },
                        new
                        {
                            Id = 2,
                            createdAt = new DateTime(2024, 3, 26, 16, 49, 9, 422, DateTimeKind.Local).AddTicks(1690),
                            email = "erhan",
                            firstName = "as",
                            lastName = "Turker",
                            password = "serdar12312"
                        });
                });

            modelBuilder.Entity("WebBlog.Entitiy.Entities.Article", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("description");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("title");

                    b.Property<DateTime>("createdAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("updatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("userId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("userId");

                    b.ToTable("Articles");

                    b.HasData(
                        new
                        {
                            Id = 2,
                            Author = "erhan",
                            Description = "akjsdnkjasashkjd",
                            Title = "sa123",
                            createdAt = new DateTime(2024, 3, 26, 16, 49, 9, 422, DateTimeKind.Local).AddTicks(4632),
                            updatedAt = new DateTime(2024, 3, 26, 16, 49, 9, 422, DateTimeKind.Local).AddTicks(4627),
                            userId = 1
                        },
                        new
                        {
                            Id = 3,
                            Author = "erhan",
                            Description = "akjsdnkjasashkjd",
                            Title = "sa123",
                            createdAt = new DateTime(2024, 3, 26, 16, 49, 9, 422, DateTimeKind.Local).AddTicks(4635),
                            updatedAt = new DateTime(2024, 3, 26, 16, 49, 9, 422, DateTimeKind.Local).AddTicks(4633),
                            userId = 1
                        },
                        new
                        {
                            Id = 4,
                            Author = "erhan",
                            Description = "akjsdnkjasashkjd",
                            Title = "sa123",
                            createdAt = new DateTime(2024, 3, 26, 16, 49, 9, 422, DateTimeKind.Local).AddTicks(4636),
                            updatedAt = new DateTime(2024, 3, 26, 16, 49, 9, 422, DateTimeKind.Local).AddTicks(4635),
                            userId = 2
                        });
                });

            modelBuilder.Entity("WebBlog.Entitiy.Entities.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("articleId")
                        .HasColumnType("int");

                    b.Property<string>("commentAuthor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("commmentDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("comment");

                    b.Property<DateTime>("createdAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("updatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("userId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("articleId");

                    b.HasIndex("userId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("WebBlog.Entitiy.Entities.Article", b =>
                {
                    b.HasOne("WebBlog.Entitiy.Entities.AppUser", "User")
                        .WithMany("Articles")
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("User");
                });

            modelBuilder.Entity("WebBlog.Entitiy.Entities.Comment", b =>
                {
                    b.HasOne("WebBlog.Entitiy.Entities.Article", "article")
                        .WithMany("Comments")
                        .HasForeignKey("articleId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("WebBlog.Entitiy.Entities.AppUser", "User")
                        .WithMany("Comments")
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("User");

                    b.Navigation("article");
                });

            modelBuilder.Entity("WebBlog.Entitiy.Entities.AppUser", b =>
                {
                    b.Navigation("Articles");

                    b.Navigation("Comments");
                });

            modelBuilder.Entity("WebBlog.Entitiy.Entities.Article", b =>
                {
                    b.Navigation("Comments");
                });
#pragma warning restore 612, 618
        }
    }
}
