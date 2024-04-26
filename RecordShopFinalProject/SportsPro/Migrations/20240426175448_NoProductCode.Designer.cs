﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RecordShop.Models;

#nullable disable

namespace RecordShop.Migrations
{
    [DbContext(typeof(RecordShopContextModel))]
    [Migration("20240426175448_NoProductCode")]
    partial class NoProductCode
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

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
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("RecordShop.Models.CountryModel", b =>
                {
                    b.Property<string>("CountryModelId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CountryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CountryModelId");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            CountryModelId = "USA",
                            CountryName = "United States"
                        },
                        new
                        {
                            CountryModelId = "CHN",
                            CountryName = "China"
                        },
                        new
                        {
                            CountryModelId = "IND",
                            CountryName = "India"
                        },
                        new
                        {
                            CountryModelId = "BRA",
                            CountryName = "Brazil"
                        },
                        new
                        {
                            CountryModelId = "IDN",
                            CountryName = "Indonesia"
                        },
                        new
                        {
                            CountryModelId = "PAK",
                            CountryName = "Pakistan"
                        },
                        new
                        {
                            CountryModelId = "BGD",
                            CountryName = "Bangladesh"
                        },
                        new
                        {
                            CountryModelId = "RUS",
                            CountryName = "Russia"
                        },
                        new
                        {
                            CountryModelId = "MEX",
                            CountryName = "Mexico"
                        },
                        new
                        {
                            CountryModelId = "JPN",
                            CountryName = "Japan"
                        },
                        new
                        {
                            CountryModelId = "DEU",
                            CountryName = "Germany"
                        },
                        new
                        {
                            CountryModelId = "VNM",
                            CountryName = "Vietnam"
                        },
                        new
                        {
                            CountryModelId = "EGY",
                            CountryName = "Egypt"
                        });
                });

            modelBuilder.Entity("RecordShop.Models.CustomerModel", b =>
                {
                    b.Property<int>("CustomerModelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerModelId"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CountryModelId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CustomerFirstName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("CustomerLastName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("CustomerModelId");

                    b.HasIndex("CountryModelId");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            CustomerModelId = 1,
                            Address = "30 Borica St",
                            City = "San Francisco",
                            CountryModelId = "USA",
                            CustomerFirstName = "Kaitlyn",
                            CustomerLastName = "Anthoni",
                            Email = "kanthoni@pge.com",
                            PhoneNumber = "812-907-0449",
                            PostalCode = "94127",
                            State = "California"
                        },
                        new
                        {
                            CustomerModelId = 2,
                            Address = "7124 44th Avenue SW",
                            City = "Seattle",
                            CountryModelId = "USA",
                            CustomerFirstName = "Ania",
                            CustomerLastName = "Irvin",
                            Email = "ani@mma.nidc.com",
                            PhoneNumber = "",
                            PostalCode = "98136",
                            State = "Washington"
                        },
                        new
                        {
                            CustomerModelId = 3,
                            Address = "27691 Pasatiempo",
                            City = "Mission Viejo",
                            CountryModelId = "USA",
                            CustomerFirstName = "Gonzalo",
                            CustomerLastName = "Keeton",
                            Email = "",
                            PhoneNumber = "123-456-7890",
                            PostalCode = "92692",
                            State = "California"
                        },
                        new
                        {
                            CustomerModelId = 4,
                            Address = "4731 Baker Ave",
                            City = "Sacramento",
                            CountryModelId = "USA",
                            CustomerFirstName = "Anton",
                            CustomerLastName = "Mauro",
                            Email = "amauro@yahoo.org",
                            PhoneNumber = "542-890-7890",
                            PostalCode = "95820",
                            State = "California"
                        },
                        new
                        {
                            CustomerModelId = 5,
                            Address = "4248 N Cedar Ave",
                            City = "Fresno",
                            CountryModelId = "USA",
                            CustomerFirstName = "Kendall",
                            CustomerLastName = "Mayte",
                            Email = "kmayte@fresno.ca.gov",
                            PhoneNumber = "612-109-1247",
                            PostalCode = "93726",
                            State = "California"
                        },
                        new
                        {
                            CustomerModelId = 6,
                            Address = "11344 Porter Valley Dr",
                            City = "Los Angeles",
                            CountryModelId = "USA",
                            CustomerFirstName = "Kenzi",
                            CustomerLastName = "Quinn",
                            Email = "kenzie@mma.jobtrak.com",
                            PhoneNumber = "912-189-6631",
                            PostalCode = "91326",
                            State = "California"
                        },
                        new
                        {
                            CustomerModelId = 7,
                            Address = "1143 S Minnewawa Ave",
                            City = "Fresno",
                            CountryModelId = "USA",
                            CustomerFirstName = "Marvin",
                            CustomerLastName = "Quintin",
                            Email = "marvin@expedata.com",
                            PhoneNumber = "612-109-1247",
                            PostalCode = "93727",
                            State = "California"
                        });
                });

            modelBuilder.Entity("RecordShop.Models.CustomerProducts", b =>
                {
                    b.Property<int>("CustomerModelId")
                        .HasColumnType("int");

                    b.Property<int>("ProductModelId")
                        .HasColumnType("int");

                    b.HasKey("CustomerModelId", "ProductModelId");

                    b.HasIndex("ProductModelId");

                    b.ToTable("CustomerProducts", (string)null);

                    b.HasData(
                        new
                        {
                            CustomerModelId = 1,
                            ProductModelId = 1
                        },
                        new
                        {
                            CustomerModelId = 2,
                            ProductModelId = 2
                        },
                        new
                        {
                            CustomerModelId = 2,
                            ProductModelId = 3
                        },
                        new
                        {
                            CustomerModelId = 3,
                            ProductModelId = 3
                        },
                        new
                        {
                            CustomerModelId = 3,
                            ProductModelId = 4
                        });
                });

            modelBuilder.Entity("RecordShop.Models.EmployeeModel", b =>
                {
                    b.Property<int>("EmployeeModelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeModelId"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmployeeModelId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            EmployeeModelId = -1,
                            Email = "",
                            FirstName = "No Employee",
                            LastName = "",
                            PhoneNumber = ""
                        },
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

            modelBuilder.Entity("RecordShop.Models.IncidentModel", b =>
                {
                    b.Property<int>("IncidentModelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IncidentModelId"));

                    b.Property<int?>("CustomerModelId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<DateTime?>("DateClosed")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateOpened")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("EmployeeModelId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("ProductModelId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("IncidentModelId");

                    b.HasIndex("CustomerModelId");

                    b.HasIndex("EmployeeModelId");

                    b.HasIndex("ProductModelId");

                    b.ToTable("Incidents");

                    b.HasData(
                        new
                        {
                            IncidentModelId = 1,
                            CustomerModelId = 1,
                            DateClosed = new DateTime(2024, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOpened = new DateTime(2024, 4, 26, 12, 54, 48, 358, DateTimeKind.Local).AddTicks(6783),
                            Description = "Record Came out of the package scratched.",
                            EmployeeModelId = 1,
                            ProductModelId = 1,
                            Title = "Scratched The Record"
                        },
                        new
                        {
                            IncidentModelId = 2,
                            CustomerModelId = 3,
                            DateClosed = new DateTime(2024, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOpened = new DateTime(2024, 4, 26, 12, 54, 48, 358, DateTimeKind.Local).AddTicks(6788),
                            Description = "Snapped In two",
                            EmployeeModelId = 2,
                            ProductModelId = 2,
                            Title = "Record Snapped"
                        },
                        new
                        {
                            IncidentModelId = 3,
                            CustomerModelId = 4,
                            DateOpened = new DateTime(2024, 4, 26, 12, 54, 48, 358, DateTimeKind.Local).AddTicks(6792),
                            Description = "Picked the wrong size record for my Record Player",
                            EmployeeModelId = 2,
                            ProductModelId = 3,
                            Title = "Wrong Size"
                        },
                        new
                        {
                            IncidentModelId = 4,
                            CustomerModelId = 6,
                            DateClosed = new DateTime(2024, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOpened = new DateTime(2024, 4, 26, 12, 54, 48, 358, DateTimeKind.Local).AddTicks(6796),
                            Description = "Wanted a new artist",
                            EmployeeModelId = 2,
                            ProductModelId = 3,
                            Title = "Didn't like the record"
                        });
                });

            modelBuilder.Entity("RecordShop.Models.Login.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

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
                });

            modelBuilder.Entity("RecordShop.Models.ProductModel", b =>
                {
                    b.Property<int>("ProductModelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductModelId"));

                    b.Property<string>("ArtistName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("GenreModelId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("Price")
                        .IsRequired()
                        .HasColumnType("float");

                    b.Property<string>("RecordName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

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
                            GenreModelId = "JAZZ",
                            ImageUrl = "/Images/Records/Frank_Sinatra/sinatras_sinatra.jpg",
                            Price = 12.99,
                            RecordName = "Sinatra's Sinatra",
                            ReleaseDate = 1963
                        },
                        new
                        {
                            ProductModelId = 2,
                            ArtistName = "Dean Martin",
                            GenreModelId = "JAZZ",
                            ImageUrl = "/Images/Records/Dean_Martin/gentle_on_my_mind.jpg",
                            Price = 10.99,
                            RecordName = "Gentle on My Mind",
                            ReleaseDate = 1968
                        },
                        new
                        {
                            ProductModelId = 3,
                            ArtistName = "Paul Anka",
                            GenreModelId = "JAZZ",
                            ImageUrl = "/Images/Records/Paul_Anka/anka.jpg",
                            Price = 5.6200000000000001,
                            RecordName = "Times of Your Life",
                            ReleaseDate = 1975
                        },
                        new
                        {
                            ProductModelId = 4,
                            ArtistName = "Bee Gees",
                            GenreModelId = "ROCK",
                            ImageUrl = "/Images/Records/Bee_Gees/mr_natural.jpg",
                            Price = 5.0,
                            RecordName = "Mr. Natural",
                            ReleaseDate = 1974
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("RecordShop.Models.Login.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("RecordShop.Models.Login.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RecordShop.Models.Login.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("RecordShop.Models.Login.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RecordShop.Models.CustomerModel", b =>
                {
                    b.HasOne("RecordShop.Models.CountryModel", "Country")
                        .WithMany()
                        .HasForeignKey("CountryModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("RecordShop.Models.CustomerProducts", b =>
                {
                    b.HasOne("RecordShop.Models.CustomerModel", "Customers")
                        .WithMany()
                        .HasForeignKey("CustomerModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RecordShop.Models.ProductModel", "Products")
                        .WithMany()
                        .HasForeignKey("ProductModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customers");

                    b.Navigation("Products");
                });

            modelBuilder.Entity("RecordShop.Models.IncidentModel", b =>
                {
                    b.HasOne("RecordShop.Models.CustomerModel", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RecordShop.Models.EmployeeModel", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RecordShop.Models.ProductModel", "Product")
                        .WithMany()
                        .HasForeignKey("ProductModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Employee");

                    b.Navigation("Product");
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
