﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Vehicle_Appraisal_WebApi.DTOs;

namespace Vehicle_Appraisal_WebApi.Migrations
{
    [DbContext(typeof(DbContextDTO))]
    [Migration("20201124055921_UpdateVehicleBought")]
    partial class UpdateVehicleBought
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Vehicle_Appraisal_WebApi.DTOs.AppUserDTO", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AppUserRolesId");

                    b.Property<bool>("ConfirmEmail");

                    b.Property<DateTime>("CreateAt");

                    b.Property<string>("Email");

                    b.Property<string>("FullName");

                    b.Property<string>("PassWord");

                    b.Property<DateTime>("UpdateAt");

                    b.Property<string>("UserName");

                    b.Property<bool>("isDelete");

                    b.HasKey("Id");

                    b.HasIndex("AppUserRolesId");

                    b.ToTable("AppUsers");
                });

            modelBuilder.Entity("Vehicle_Appraisal_WebApi.DTOs.AppUserRoleDTO", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateAt");

                    b.Property<string>("Name");

                    b.Property<DateTime>("UpdateAt");

                    b.HasKey("Id");

                    b.ToTable("AppUserRoles");
                });

            modelBuilder.Entity("Vehicle_Appraisal_WebApi.DTOs.ConditionDTO", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateAt");

                    b.Property<string>("ImagePath");

                    b.Property<string>("Note");

                    b.Property<string>("Type");

                    b.Property<DateTime>("UpdateAt");

                    b.Property<int>("VehicleId");

                    b.HasKey("Id");

                    b.HasIndex("VehicleId");

                    b.ToTable("Conditions");
                });

            modelBuilder.Entity("Vehicle_Appraisal_WebApi.DTOs.CustomerDTO", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address1");

                    b.Property<string>("Address2");

                    b.Property<string>("City");

                    b.Property<string>("Country");

                    b.Property<DateTime>("CreateAt");

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("Phone");

                    b.Property<DateTime>("UpdateAt");

                    b.Property<bool>("isDelete");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Vehicle_Appraisal_WebApi.DTOs.MakeDTO", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateAt");

                    b.Property<string>("Name");

                    b.Property<DateTime>("UpdateAt");

                    b.Property<bool>("isDelete");

                    b.HasKey("Id");

                    b.ToTable("Makes");
                });

            modelBuilder.Entity("Vehicle_Appraisal_WebApi.DTOs.ModelDTO", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateAt");

                    b.Property<string>("Name");

                    b.Property<DateTime>("UpdateAt");

                    b.Property<string>("Year");

                    b.Property<bool>("isDelete");

                    b.HasKey("Id");

                    b.ToTable("Models");
                });

            modelBuilder.Entity("Vehicle_Appraisal_WebApi.DTOs.VehicleAppraisalDTO", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AppraisalValue");

                    b.Property<DateTime>("CreateAt");

                    b.Property<DateTime>("UpdateAt");

                    b.Property<int>("VehicleId");

                    b.HasKey("Id");

                    b.HasIndex("VehicleId");

                    b.ToTable("VehicleAppraisals");
                });

            modelBuilder.Entity("Vehicle_Appraisal_WebApi.DTOs.VehicleBoughtDTO", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateAt");

                    b.Property<DateTime>("UpdateAt");

                    b.Property<int>("vehicleAppraisalId");

                    b.HasKey("Id");

                    b.HasIndex("vehicleAppraisalId");

                    b.ToTable("VehicleBoughts");
                });

            modelBuilder.Entity("Vehicle_Appraisal_WebApi.DTOs.VehicleCrawlDataDTO", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateAt");

                    b.Property<string>("Image");

                    b.Property<string>("Name");

                    b.Property<DateTime>("UpdateAt");

                    b.Property<string>("Value");

                    b.HasKey("Id");

                    b.ToTable("VehicleCrawlDatas");
                });

            modelBuilder.Entity("Vehicle_Appraisal_WebApi.DTOs.VehicleDTO", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AppUserId");

                    b.Property<DateTime>("CreateAt");

                    b.Property<int>("CustomerId");

                    b.Property<string>("Engine");

                    b.Property<int>("MakeId");

                    b.Property<int>("ModelId");

                    b.Property<string>("Odometer");

                    b.Property<DateTime>("UpdateAt");

                    b.Property<string>("VIN");

                    b.Property<bool>("isDelete");

                    b.HasKey("Id");

                    b.HasIndex("AppUserId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("MakeId");

                    b.HasIndex("ModelId");

                    b.ToTable("Vehicles");
                });

            modelBuilder.Entity("Vehicle_Appraisal_WebApi.DTOs.AppUserDTO", b =>
                {
                    b.HasOne("Vehicle_Appraisal_WebApi.DTOs.AppUserRoleDTO", "AppUserRolesDTO")
                        .WithMany("AppUserDTOs")
                        .HasForeignKey("AppUserRolesId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Vehicle_Appraisal_WebApi.DTOs.ConditionDTO", b =>
                {
                    b.HasOne("Vehicle_Appraisal_WebApi.DTOs.VehicleDTO", "VehicleDTO")
                        .WithMany("ConditionDTOs")
                        .HasForeignKey("VehicleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Vehicle_Appraisal_WebApi.DTOs.VehicleAppraisalDTO", b =>
                {
                    b.HasOne("Vehicle_Appraisal_WebApi.DTOs.VehicleDTO", "VehicleDTO")
                        .WithMany("VehicleAppraisalDTOs")
                        .HasForeignKey("VehicleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Vehicle_Appraisal_WebApi.DTOs.VehicleBoughtDTO", b =>
                {
                    b.HasOne("Vehicle_Appraisal_WebApi.DTOs.VehicleAppraisalDTO", "VehicleAppraisalDTO")
                        .WithMany("VehicleBoughtDTOs")
                        .HasForeignKey("vehicleAppraisalId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Vehicle_Appraisal_WebApi.DTOs.VehicleDTO", b =>
                {
                    b.HasOne("Vehicle_Appraisal_WebApi.DTOs.AppUserDTO", "AppUserDTO")
                        .WithMany("VehicleDTOs")
                        .HasForeignKey("AppUserId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Vehicle_Appraisal_WebApi.DTOs.CustomerDTO", "CustomerDTO")
                        .WithMany("VehicleDTOs")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Vehicle_Appraisal_WebApi.DTOs.MakeDTO", "MakeDTO")
                        .WithMany("VehicleDTOs")
                        .HasForeignKey("MakeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Vehicle_Appraisal_WebApi.DTOs.ModelDTO", "ModelDTO")
                        .WithMany("VehicleDTOs")
                        .HasForeignKey("ModelId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}