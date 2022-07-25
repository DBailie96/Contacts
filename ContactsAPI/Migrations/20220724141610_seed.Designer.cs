﻿// <auto-generated />
using System;
using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ContactsAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220724141610_seed")]
    partial class seed
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Entities.Models.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("contact");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "test",
                            DateOfBirth = new DateTime(1996, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Daniel",
                            LastName = "Bailie",
                            PhoneNumber = "0799693943"
                        },
                        new
                        {
                            Id = 2,
                            Address = "test",
                            DateOfBirth = new DateTime(1996, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Armand",
                            LastName = "Van Den Berg",
                            PhoneNumber = "0799693943"
                        },
                        new
                        {
                            Id = 3,
                            Address = "test",
                            DateOfBirth = new DateTime(1996, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Andrew",
                            LastName = "Trautmann",
                            PhoneNumber = "0799693943"
                        },
                        new
                        {
                            Id = 4,
                            Address = "test",
                            DateOfBirth = new DateTime(1996, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Ashton",
                            LastName = "Naidoo",
                            PhoneNumber = "0799693943"
                        },
                        new
                        {
                            Id = 5,
                            Address = "test",
                            DateOfBirth = new DateTime(1996, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Iviwe",
                            LastName = "Malotana",
                            PhoneNumber = "0799693943"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}