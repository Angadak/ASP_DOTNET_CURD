﻿// <auto-generated />
using System;
using MagicVilla.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MagicVilla.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20230614051208_SeedVillaTable")]
    partial class SeedVillaTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MagicVilla.Models.Villa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Aminety")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created_at")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Occupancy")
                        .HasColumnType("int");

                    b.Property<int>("Rate")
                        .HasColumnType("int");

                    b.Property<DateTime>("Uupdated_at")
                        .HasColumnType("datetime2");

                    b.Property<string>("image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("sqrt")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("VillaAPI");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Aminety = "",
                            Created_at = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "!Loremasdfghjkl;qwertyuiozxcvbnm,asdfghjkqwertyuio",
                            Name = "Royal villa",
                            Occupancy = 10,
                            Rate = 200,
                            Uupdated_at = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            image = "",
                            sqrt = 550
                        },
                        new
                        {
                            Id = 2,
                            Aminety = "",
                            Created_at = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "!Loremasdfghjkl;qwertyuiozxcvbnm,asdfghjkqwertyuio",
                            Name = "luxary  villa",
                            Occupancy = 10,
                            Rate = 200,
                            Uupdated_at = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            image = "",
                            sqrt = 550
                        },
                        new
                        {
                            Id = 3,
                            Aminety = "",
                            Created_at = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "!Loremasdfghjkl;qwertyuiozxcvbnm,asdfghjkqwertyuio",
                            Name = "Ancient villa",
                            Occupancy = 10,
                            Rate = 200,
                            Uupdated_at = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            image = "",
                            sqrt = 550
                        },
                        new
                        {
                            Id = 4,
                            Aminety = "",
                            Created_at = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "!Loremasdfghjkl;qwertyuiozxcvbnm,asdfghjkqwertyuio",
                            Name = "palace villa",
                            Occupancy = 10,
                            Rate = 200,
                            Uupdated_at = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            image = "",
                            sqrt = 550
                        },
                        new
                        {
                            Id = 5,
                            Aminety = "",
                            Created_at = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "!Loremasdfghjkl;qwertyuiozxcvbnm,asdfghjkqwertyuio",
                            Name = "water villa",
                            Occupancy = 10,
                            Rate = 200,
                            Uupdated_at = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            image = "",
                            sqrt = 550
                        },
                        new
                        {
                            Id = 6,
                            Aminety = "",
                            Created_at = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "!Loremasdfghjkl;qwertyuiozxcvbnm,asdfghjkqwertyuio",
                            Name = "fire villa",
                            Occupancy = 10,
                            Rate = 200,
                            Uupdated_at = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            image = "",
                            sqrt = 550
                        });
                });
#pragma warning restore 612, 618
        }
    }
}