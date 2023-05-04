﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication2.Databases;

#nullable disable

namespace WebApplication2.Migrations
{
    [DbContext(typeof(DataDbContext))]
    partial class DataDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("WebApplication2.Models.employees", b =>
                {
                    b.Property<string>("empId")
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("empName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("hireDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("phoneNumber")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("position_Id")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("empId");

                    b.ToTable("employees");
                });

            modelBuilder.Entity("WebApplication2.Models.positions", b =>
                {
                    b.Property<string>("position_Id")
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<float>("baseSalary")
                        .HasColumnType("float");

                    b.Property<string>("position_Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<float>("salaryIncreaseRate")
                        .HasColumnType("float");

                    b.HasKey("position_Id");

                    b.ToTable("positions");
                });
#pragma warning restore 612, 618
        }
    }
}