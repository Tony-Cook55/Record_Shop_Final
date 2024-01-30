﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RecordShop.Models;

#nullable disable

namespace RecordShop.Migrations
{
    [DbContext(typeof(RecordShopContextModel))]
    partial class ProductsContextModelModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("RecordShop.Models.EmployeeModel", b =>
                {
                    b.Property<int>("EmployeeModelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeModelId"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmployeeModelId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            EmployeeModelId = 1,
                            Email = "alison@gmail.com",
                            FirstName = "Alison",
                            LastName = "Diaz",
                            PhoneNumber = "800-555-0443"
                        },
                        new
                        {
                            EmployeeModelId = 2,
                            Email = "awilson@gmail.com",
                            FirstName = "Andrew",
                            LastName = "Wilson",
                            PhoneNumber = "800-555-0449"
                        },
                        new
                        {
                            EmployeeModelId = 3,
                            Email = "gflori@gmail.com",
                            FirstName = "Gina",
                            LastName = "Flori",
                            PhoneNumber = "800-555-0459"
                        },
                        new
                        {
                            EmployeeModelId = 4,
                            Email = "gunter@gmail.com",
                            FirstName = "Gunter",
                            LastName = "Wendt",
                            PhoneNumber = "800-555-0400"
                        },
                        new
                        {
                            EmployeeModelId = 5,
                            Email = "jason@gmail.com",
                            FirstName = "Jason",
                            LastName = "Lee",
                            PhoneNumber = "800-555-0444"
                        });
                });

            modelBuilder.Entity("RecordShop.Models.GenreModel", b =>
                {
                    b.Property<string>("GenreModelId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("GenreName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GenreModelId");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            GenreModelId = "BLUES",
                            GenreName = "Blues"
                        },
                        new
                        {
                            GenreModelId = "COUNTRY",
                            GenreName = "Country"
                        },
                        new
                        {
                            GenreModelId = "DISCO",
                            GenreName = "Disco"
                        },
                        new
                        {
                            GenreModelId = "EASY",
                            GenreName = "Easy Listening"
                        },
                        new
                        {
                            GenreModelId = "ELECTRONIC",
                            GenreName = "Electronic"
                        },
                        new
                        {
                            GenreModelId = "FUNK",
                            GenreName = "Funk"
                        },
                        new
                        {
                            GenreModelId = "HIP",
                            GenreName = "Hip Hop"
                        },
                        new
                        {
                            GenreModelId = "JAZZ",
                            GenreName = "Jazz"
                        },
                        new
                        {
                            GenreModelId = "METAL",
                            GenreName = "Metal"
                        },
                        new
                        {
                            GenreModelId = "POP",
                            GenreName = "Pop"
                        },
                        new
                        {
                            GenreModelId = "PUNK",
                            GenreName = "Punk"
                        },
                        new
                        {
                            GenreModelId = "RB",
                            GenreName = "R&B"
                        },
                        new
                        {
                            GenreModelId = "ROCK",
                            GenreName = "Rock"
                        },
                        new
                        {
                            GenreModelId = "SOFTROCK",
                            GenreName = "Soft Rock"
                        },
                        new
                        {
                            GenreModelId = "SOUL",
                            GenreName = "Soul"
                        },
                        new
                        {
                            GenreModelId = "SWING",
                            GenreName = "Swing"
                        });
                });

            modelBuilder.Entity("RecordShop.Models.ProductModel", b =>
                {
                    b.Property<int>("ProductModelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductModelId"));

                    b.Property<string>("ArtistName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("GenreModelId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<double?>("Price")
                        .IsRequired()
                        .HasColumnType("float");

                    b.Property<string>("RecordName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("ReleaseDate")
                        .IsRequired()
                        .HasColumnType("int");

                    b.HasKey("ProductModelId");

                    b.HasIndex("GenreModelId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductModelId = 1,
                            ArtistName = "Frank Sinatra",
                            Code = "FSJAZZ",
                            GenreModelId = "JAZZ",
                            Price = 12.99,
                            RecordName = "Sinatra's Sinatra",
                            ReleaseDate = 1963
                        },
                        new
                        {
                            ProductModelId = 2,
                            ArtistName = "Dean Martin",
                            Code = "DMJAZZ",
                            GenreModelId = "JAZZ",
                            Price = 10.99,
                            RecordName = "Gentle on My Mind",
                            ReleaseDate = 1968
                        },
                        new
                        {
                            ProductModelId = 3,
                            ArtistName = "Paul Anka",
                            Code = "PAJAZZ",
                            GenreModelId = "JAZZ",
                            Price = 5.6200000000000001,
                            RecordName = "Times of Your Life",
                            ReleaseDate = 1975
                        },
                        new
                        {
                            ProductModelId = 4,
                            ArtistName = "Bee Gees",
                            Code = "BGROCK",
                            GenreModelId = "ROCK",
                            Price = 5.0,
                            RecordName = "Mr. Natural",
                            ReleaseDate = 1974
                        });
                });

            modelBuilder.Entity("RecordShop.Models.ProductModel", b =>
                {
                    b.HasOne("RecordShop.Models.GenreModel", "Genre")
                        .WithMany()
                        .HasForeignKey("GenreModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genre");
                });
#pragma warning restore 612, 618
        }
    }
}
