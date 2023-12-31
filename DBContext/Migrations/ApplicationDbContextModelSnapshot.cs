﻿// <auto-generated />
using DBContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DBContext.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Entitys.TaxExemptVehicles", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TaxExemptVehicles");
                });

            modelBuilder.Entity("Entitys.TaxRules", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("MaxHourTime")
                        .HasColumnType("int");

                    b.Property<int>("MaxMinuteTime")
                        .HasColumnType("int");

                    b.Property<int>("MinHourTime")
                        .HasColumnType("int");

                    b.Property<int>("MinMinuteTime")
                        .HasColumnType("int");

                    b.Property<int>("TaxAmount")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("TaxRules");
                });
#pragma warning restore 612, 618
        }
    }
}
