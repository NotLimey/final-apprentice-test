﻿// <auto-generated />
using System;
using API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace API.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240524143740_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("API.Models.Identity.ApplicationRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("API.Models.Identity.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("AvatarUrl")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsAnonymous")
                        .HasColumnType("boolean");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("API.Models.Restaurant", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FoodType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double>("Latitude")
                        .HasColumnType("double precision");

                    b.Property<double>("Longitude")
                        .HasColumnType("double precision");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Slug")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Summary")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTimeOffset>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Website")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("Slug")
                        .IsUnique();

                    b.ToTable("Restaurants");
                });

            modelBuilder.Entity("API.Models.Review", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("AmbianceRating")
                        .HasColumnType("integer");

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateOnly>("DateVisited")
                        .HasColumnType("date");

                    b.Property<int>("FoodQualityRating")
                        .HasColumnType("integer");

                    b.Property<int>("OverallRating")
                        .HasColumnType("integer");

                    b.Property<Guid>("RestaurantId")
                        .HasColumnType("uuid");

                    b.Property<int>("ServiceQualityRating")
                        .HasColumnType("integer");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTimeOffset>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("ValueForMoneyRating")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("RestaurantId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("text");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .HasColumnType("text");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("API.Models.Restaurant", b =>
                {
                    b.OwnsOne("API.Models.OpeningHours", "OpeningHours", b1 =>
                        {
                            b1.Property<Guid>("RestaurantId")
                                .HasColumnType("uuid");

                            b1.HasKey("RestaurantId");

                            b1.ToTable("Restaurants");

                            b1.ToJson("OpeningHours");

                            b1.WithOwner()
                                .HasForeignKey("RestaurantId");

                            b1.OwnsOne("API.Models.Hours", "Friday", b2 =>
                                {
                                    b2.Property<Guid>("OpeningHoursRestaurantId")
                                        .HasColumnType("uuid");

                                    b2.Property<TimeSpan>("ClosesAt")
                                        .HasColumnType("interval");

                                    b2.Property<TimeSpan>("OpensAt")
                                        .HasColumnType("interval");

                                    b2.HasKey("OpeningHoursRestaurantId");

                                    b2.ToTable("Restaurants");

                                    b2.WithOwner()
                                        .HasForeignKey("OpeningHoursRestaurantId");
                                });

                            b1.OwnsOne("API.Models.Hours", "Monday", b2 =>
                                {
                                    b2.Property<Guid>("OpeningHoursRestaurantId")
                                        .HasColumnType("uuid");

                                    b2.Property<TimeSpan>("ClosesAt")
                                        .HasColumnType("interval");

                                    b2.Property<TimeSpan>("OpensAt")
                                        .HasColumnType("interval");

                                    b2.HasKey("OpeningHoursRestaurantId");

                                    b2.ToTable("Restaurants");

                                    b2.WithOwner()
                                        .HasForeignKey("OpeningHoursRestaurantId");
                                });

                            b1.OwnsOne("API.Models.Hours", "Saturday", b2 =>
                                {
                                    b2.Property<Guid>("OpeningHoursRestaurantId")
                                        .HasColumnType("uuid");

                                    b2.Property<TimeSpan>("ClosesAt")
                                        .HasColumnType("interval");

                                    b2.Property<TimeSpan>("OpensAt")
                                        .HasColumnType("interval");

                                    b2.HasKey("OpeningHoursRestaurantId");

                                    b2.ToTable("Restaurants");

                                    b2.WithOwner()
                                        .HasForeignKey("OpeningHoursRestaurantId");
                                });

                            b1.OwnsOne("API.Models.Hours", "Sunday", b2 =>
                                {
                                    b2.Property<Guid>("OpeningHoursRestaurantId")
                                        .HasColumnType("uuid");

                                    b2.Property<TimeSpan>("ClosesAt")
                                        .HasColumnType("interval");

                                    b2.Property<TimeSpan>("OpensAt")
                                        .HasColumnType("interval");

                                    b2.HasKey("OpeningHoursRestaurantId");

                                    b2.ToTable("Restaurants");

                                    b2.WithOwner()
                                        .HasForeignKey("OpeningHoursRestaurantId");
                                });

                            b1.OwnsOne("API.Models.Hours", "Thursday", b2 =>
                                {
                                    b2.Property<Guid>("OpeningHoursRestaurantId")
                                        .HasColumnType("uuid");

                                    b2.Property<TimeSpan>("ClosesAt")
                                        .HasColumnType("interval");

                                    b2.Property<TimeSpan>("OpensAt")
                                        .HasColumnType("interval");

                                    b2.HasKey("OpeningHoursRestaurantId");

                                    b2.ToTable("Restaurants");

                                    b2.WithOwner()
                                        .HasForeignKey("OpeningHoursRestaurantId");
                                });

                            b1.OwnsOne("API.Models.Hours", "Tuesday", b2 =>
                                {
                                    b2.Property<Guid>("OpeningHoursRestaurantId")
                                        .HasColumnType("uuid");

                                    b2.Property<TimeSpan>("ClosesAt")
                                        .HasColumnType("interval");

                                    b2.Property<TimeSpan>("OpensAt")
                                        .HasColumnType("interval");

                                    b2.HasKey("OpeningHoursRestaurantId");

                                    b2.ToTable("Restaurants");

                                    b2.WithOwner()
                                        .HasForeignKey("OpeningHoursRestaurantId");
                                });

                            b1.OwnsOne("API.Models.Hours", "Wednesday", b2 =>
                                {
                                    b2.Property<Guid>("OpeningHoursRestaurantId")
                                        .HasColumnType("uuid");

                                    b2.Property<TimeSpan>("ClosesAt")
                                        .HasColumnType("interval");

                                    b2.Property<TimeSpan>("OpensAt")
                                        .HasColumnType("interval");

                                    b2.HasKey("OpeningHoursRestaurantId");

                                    b2.ToTable("Restaurants");

                                    b2.WithOwner()
                                        .HasForeignKey("OpeningHoursRestaurantId");
                                });

                            b1.Navigation("Friday");

                            b1.Navigation("Monday");

                            b1.Navigation("Saturday");

                            b1.Navigation("Sunday");

                            b1.Navigation("Thursday");

                            b1.Navigation("Tuesday");

                            b1.Navigation("Wednesday");
                        });

                    b.Navigation("OpeningHours")
                        .IsRequired();
                });

            modelBuilder.Entity("API.Models.Review", b =>
                {
                    b.HasOne("API.Models.Restaurant", "Restaurant")
                        .WithMany("Reviews")
                        .HasForeignKey("RestaurantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Restaurant");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("API.Models.Identity.ApplicationRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("API.Models.Identity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("API.Models.Identity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("API.Models.Identity.ApplicationRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("API.Models.Identity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("API.Models.Identity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("API.Models.Restaurant", b =>
                {
                    b.Navigation("Reviews");
                });
#pragma warning restore 612, 618
        }
    }
}
