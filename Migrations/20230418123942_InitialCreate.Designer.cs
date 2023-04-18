﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WpfApp1.Entities;

#nullable disable

namespace WpfApp1.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230418123942_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("WpfApp1.Entities.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"), 1L, 1);

                    b.Property<string>("CategoryDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Designation")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("WpfApp1.Entities.Client", b =>
                {
                    b.Property<int>("ClientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClientId"), 1L, 1);

                    b.Property<string>("BonusCard")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("FIO")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sex")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClientId");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("WpfApp1.Entities.HotelRoom", b =>
                {
                    b.Property<int>("HotelRoomId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HotelRoomId"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("CostPerDay")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Floor")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfSeats")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("HotelRoomId");

                    b.HasIndex("CategoryId");

                    b.ToTable("HotelRooms");
                });

            modelBuilder.Entity("WpfApp1.Entities.MigrationCard", b =>
                {
                    b.Property<int>("MigrationCardId")
                        .HasColumnType("int");

                    b.Property<string>("CardNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<string>("From")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StayUntil")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StayWith")
                        .HasColumnType("datetime2");

                    b.Property<string>("TripPurpose")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MigrationCardId");

                    b.ToTable("MigrationCards");
                });

            modelBuilder.Entity("WpfApp1.Entities.Passport", b =>
                {
                    b.Property<int>("PassportId")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<string>("CountryIssue")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DocumentType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KemVidan")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Series")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PassportId");

                    b.ToTable("Passports");
                });

            modelBuilder.Entity("WpfApp1.Entities.Treaty", b =>
                {
                    b.Property<int>("TreatyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TreatyId"), 1L, 1);

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateDeparture")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateEntrance")
                        .HasColumnType("datetime2");

                    b.Property<int>("HotelNumber")
                        .HasColumnType("int");

                    b.Property<int>("HotelRoomId")
                        .HasColumnType("int");

                    b.Property<string>("MethodOfPay")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SumOfPay")
                        .HasColumnType("int");

                    b.Property<DateTime>("TreatyDate")
                        .HasColumnType("datetime2");

                    b.HasKey("TreatyId");

                    b.HasIndex("ClientId");

                    b.HasIndex("HotelRoomId");

                    b.ToTable("Treaties");
                });

            modelBuilder.Entity("WpfApp1.Entities.HotelRoom", b =>
                {
                    b.HasOne("WpfApp1.Entities.Category", "Category")
                        .WithMany("HotelRooms")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("WpfApp1.Entities.MigrationCard", b =>
                {
                    b.HasOne("WpfApp1.Entities.Client", "Client")
                        .WithOne("MigrationCard")
                        .HasForeignKey("WpfApp1.Entities.MigrationCard", "MigrationCardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");
                });

            modelBuilder.Entity("WpfApp1.Entities.Passport", b =>
                {
                    b.HasOne("WpfApp1.Entities.Client", "Client")
                        .WithOne("Passport")
                        .HasForeignKey("WpfApp1.Entities.Passport", "PassportId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");
                });

            modelBuilder.Entity("WpfApp1.Entities.Treaty", b =>
                {
                    b.HasOne("WpfApp1.Entities.Client", "Client")
                        .WithMany("Treaties")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WpfApp1.Entities.HotelRoom", "HotelRoom")
                        .WithMany("Treaties")
                        .HasForeignKey("HotelRoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");

                    b.Navigation("HotelRoom");
                });

            modelBuilder.Entity("WpfApp1.Entities.Category", b =>
                {
                    b.Navigation("HotelRooms");
                });

            modelBuilder.Entity("WpfApp1.Entities.Client", b =>
                {
                    b.Navigation("MigrationCard")
                        .IsRequired();

                    b.Navigation("Passport")
                        .IsRequired();

                    b.Navigation("Treaties");
                });

            modelBuilder.Entity("WpfApp1.Entities.HotelRoom", b =>
                {
                    b.Navigation("Treaties");
                });
#pragma warning restore 612, 618
        }
    }
}