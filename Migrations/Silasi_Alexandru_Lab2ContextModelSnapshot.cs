﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Silasi_Alexandru_Lab2.Data;

#nullable disable

namespace Silasi_Alexandru_Lab2.Migrations
{
    [DbContext(typeof(Silasi_Alexandru_Lab2Context))]
    partial class Silasi_Alexandru_Lab2ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.23")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Silasi_Alexandru_Lab2.Models.Author", b =>
                {
                    b.Property<int>("AuthorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AuthorID"), 1L, 1);

                    b.Property<string>("firstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AuthorID");

                    b.ToTable("Author");
                });

            modelBuilder.Entity("Silasi_Alexandru_Lab2.Models.Book", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<int?>("AuthorID")
                        .HasColumnType("int");

                    b.Property<decimal>("price")
                        .HasColumnType("decimal(6,2)");

                    b.Property<DateTime>("publishDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("publisherId")
                        .HasColumnType("int");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("AuthorID");

                    b.HasIndex("publisherId");

                    b.ToTable("Book");
                });

            modelBuilder.Entity("Silasi_Alexandru_Lab2.Models.BookCategory", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("BookID")
                        .HasColumnType("int");

                    b.Property<int>("CategoryID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("BookID");

                    b.HasIndex("CategoryID");

                    b.ToTable("BookCategory");
                });

            modelBuilder.Entity("Silasi_Alexandru_Lab2.Models.Category", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("Silasi_Alexandru_Lab2.Models.Publisher", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Publisher");
                });

            modelBuilder.Entity("Silasi_Alexandru_Lab2.Models.Book", b =>
                {
                    b.HasOne("Silasi_Alexandru_Lab2.Models.Author", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorID");

                    b.HasOne("Silasi_Alexandru_Lab2.Models.Publisher", "Publisher")
                        .WithMany("Books")
                        .HasForeignKey("publisherId");

                    b.Navigation("Author");

                    b.Navigation("Publisher");
                });

            modelBuilder.Entity("Silasi_Alexandru_Lab2.Models.BookCategory", b =>
                {
                    b.HasOne("Silasi_Alexandru_Lab2.Models.Book", "Book")
                        .WithMany("BookCategories")
                        .HasForeignKey("BookID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Silasi_Alexandru_Lab2.Models.Category", "Category")
                        .WithMany("BookCategories")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Silasi_Alexandru_Lab2.Models.Book", b =>
                {
                    b.Navigation("BookCategories");
                });

            modelBuilder.Entity("Silasi_Alexandru_Lab2.Models.Category", b =>
                {
                    b.Navigation("BookCategories");
                });

            modelBuilder.Entity("Silasi_Alexandru_Lab2.Models.Publisher", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}
