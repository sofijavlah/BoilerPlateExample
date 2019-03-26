﻿// <auto-generated />
using System;
using BoilerPlateExample.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BoilerPlateExample.Migrations
{
    [DbContext(typeof(BoilerPlateExampleDbContext))]
    [Migration("20190326105355_prva")]
    partial class prva
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BoilerPlateExample.Models.Device", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("EmployeeId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Devices");
                });

            modelBuilder.Entity("BoilerPlateExample.Models.DeviceUsage", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("DeviceId");

                    b.Property<long?>("EmployeeId");

                    b.Property<DateTime>("From");

                    b.Property<DateTime?>("To");

                    b.HasKey("Id");

                    b.HasIndex("DeviceId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("DeviceUsages");
                });

            modelBuilder.Entity("BoilerPlateExample.Models.Employee", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<long>("OfficeId");

                    b.HasKey("Id");

                    b.HasIndex("OfficeId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("BoilerPlateExample.Models.Office", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.HasKey("Id");

                    b.ToTable("Offices");
                });

            modelBuilder.Entity("BoilerPlateExample.Models.Device", b =>
                {
                    b.HasOne("BoilerPlateExample.Models.Employee", "Employee")
                        .WithMany("Devices")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BoilerPlateExample.Models.DeviceUsage", b =>
                {
                    b.HasOne("BoilerPlateExample.Models.Device", "Device")
                        .WithMany("UsageList")
                        .HasForeignKey("DeviceId");

                    b.HasOne("BoilerPlateExample.Models.Employee", "Employee")
                        .WithMany("UsageList")
                        .HasForeignKey("EmployeeId");
                });

            modelBuilder.Entity("BoilerPlateExample.Models.Employee", b =>
                {
                    b.HasOne("BoilerPlateExample.Models.Office", "Office")
                        .WithMany("Employees")
                        .HasForeignKey("OfficeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
