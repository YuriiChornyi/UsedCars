﻿// <auto-generated />
using System;
using DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DAL.Migrations
{
    [DbContext(typeof(UsedCarsDbContext))]
    [Migration("20181025100347_Enable lazy loading")]
    partial class Enablelazyloading
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DAL.Entities.Advertisement", b =>
                {
                    b.Property<Guid>("AdvertisementId")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("CarId");

                    b.Property<string>("Description")
                        .HasMaxLength(500);

                    b.Property<double>("Price");

                    b.Property<Guid>("UserId");

                    b.HasKey("AdvertisementId");

                    b.HasIndex("CarId");

                    b.HasIndex("UserId");

                    b.ToTable("Advertisement");
                });

            modelBuilder.Entity("DAL.Entities.Car", b =>
                {
                    b.Property<Guid>("CarId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CarModelId");

                    b.Property<int>("EngineId");

                    b.Property<DateTime?>("ProductionYear");

                    b.Property<int>("TransmissionId");

                    b.Property<string>("VinCode");

                    b.HasKey("CarId");

                    b.HasIndex("CarModelId");

                    b.HasIndex("EngineId");

                    b.HasIndex("TransmissionId");

                    b.ToTable("Car");
                });

            modelBuilder.Entity("DAL.Entities.CarModel", b =>
                {
                    b.Property<int>("CarModelId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CarModelName")
                        .HasMaxLength(50);

                    b.Property<int>("ManufacturerId");

                    b.HasKey("CarModelId");

                    b.HasIndex("ManufacturerId");

                    b.ToTable("CarModel");
                });

            modelBuilder.Entity("DAL.Entities.Engine", b =>
                {
                    b.Property<int>("EngineId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EngineTypeId");

                    b.Property<int>("HP");

                    b.Property<string>("Value");

                    b.HasKey("EngineId");

                    b.HasIndex("EngineTypeId");

                    b.ToTable("Engine");
                });

            modelBuilder.Entity("DAL.Entities.EngineType", b =>
                {
                    b.Property<int>("EngineTypeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Type")
                        .HasMaxLength(50);

                    b.HasKey("EngineTypeId");

                    b.ToTable("EngineType");
                });

            modelBuilder.Entity("DAL.Entities.GearBoxType", b =>
                {
                    b.Property<int>("GearBoxTypeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Type")
                        .HasMaxLength(50);

                    b.HasKey("GearBoxTypeId");

                    b.ToTable("GearBoxType");
                });

            modelBuilder.Entity("DAL.Entities.Manufacturer", b =>
                {
                    b.Property<int>("ManufacturerId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ManufacturerName")
                        .HasMaxLength(50);

                    b.HasKey("ManufacturerId");

                    b.ToTable("Manufacturer");
                });

            modelBuilder.Entity("DAL.Entities.Photo", b =>
                {
                    b.Property<int>("PhotoId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<Guid>("AdvertisementId");

                    b.Property<string>("PhotoURL");

                    b.HasKey("PhotoId");

                    b.HasIndex("AdvertisementId");

                    b.ToTable("Photo");
                });

            modelBuilder.Entity("DAL.Entities.Transmission", b =>
                {
                    b.Property<int>("TransmissionId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("GearBoxTypeId");

                    b.Property<int>("TransmissionTypeId");

                    b.HasKey("TransmissionId");

                    b.HasIndex("GearBoxTypeId");

                    b.HasIndex("TransmissionTypeId");

                    b.ToTable("Transmission");
                });

            modelBuilder.Entity("DAL.Entities.TransmissionType", b =>
                {
                    b.Property<int>("TransmissionTypeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Type")
                        .HasMaxLength(50);

                    b.HasKey("TransmissionTypeId");

                    b.ToTable("TransmissionType");
                });

            modelBuilder.Entity("DAL.Entities.User", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email")
                        .HasMaxLength(50);

                    b.Property<string>("Name")
                        .HasMaxLength(50);

                    b.Property<string>("Phone")
                        .HasMaxLength(50);

                    b.Property<DateTime?>("RegistrationDate");

                    b.HasKey("UserId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("DAL.Entities.Advertisement", b =>
                {
                    b.HasOne("DAL.Entities.Car", "Car")
                        .WithMany()
                        .HasForeignKey("CarId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DAL.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DAL.Entities.Car", b =>
                {
                    b.HasOne("DAL.Entities.CarModel", "CarModel")
                        .WithMany()
                        .HasForeignKey("CarModelId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DAL.Entities.Engine", "Engine")
                        .WithMany()
                        .HasForeignKey("EngineId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DAL.Entities.Transmission", "Transmission")
                        .WithMany()
                        .HasForeignKey("TransmissionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DAL.Entities.CarModel", b =>
                {
                    b.HasOne("DAL.Entities.Manufacturer", "Manufacturer")
                        .WithMany("CarModels")
                        .HasForeignKey("ManufacturerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DAL.Entities.Engine", b =>
                {
                    b.HasOne("DAL.Entities.EngineType", "EngineType")
                        .WithMany()
                        .HasForeignKey("EngineTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DAL.Entities.Photo", b =>
                {
                    b.HasOne("DAL.Entities.Advertisement", "Advertisement")
                        .WithMany()
                        .HasForeignKey("AdvertisementId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DAL.Entities.Transmission", b =>
                {
                    b.HasOne("DAL.Entities.GearBoxType", "GearBoxType")
                        .WithMany()
                        .HasForeignKey("GearBoxTypeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DAL.Entities.TransmissionType", "TransmissionType")
                        .WithMany()
                        .HasForeignKey("TransmissionTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
