﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SmartAdmin.Data.Models;

namespace SmartAdmin.Data.Migrations
{
    [DbContext(typeof(SmartDbContext))]
    [Migration("20200613080534_md_category")]
    partial class md_category
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SmartAdmin.Entity.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<int>("TenantId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("SmartAdmin.Entity.Models.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(12)")
                        .HasMaxLength(12);

                    b.Property<string>("Contect")
                        .HasColumnType("nvarchar(12)")
                        .HasMaxLength(12);

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<DateTime>("RegisterDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("TenantId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Code")
                        .IsUnique()
                        .HasFilter("[Code] IS NOT NULL");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Companies");
                });
#pragma warning restore 612, 618
        }
    }
}
