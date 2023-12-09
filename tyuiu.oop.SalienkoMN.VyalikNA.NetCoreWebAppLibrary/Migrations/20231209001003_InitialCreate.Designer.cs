﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace tyuiu.oop.SalienkoMN.VyalikNA.NetCoreWebAppLibrary.Migrations
{
    [DbContext(typeof(LibraryContext))]
    [Migration("20231209001003_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.0");

            modelBuilder.Entity("tyuiu.oop.SalienkoMN.VyalikNA.NetCoreWebAppLibrary.DataModels.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Author")
                        .HasColumnType("TEXT");

                    b.Property<int?>("BookShelf")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Book");
                });

            modelBuilder.Entity("tyuiu.oop.SalienkoMN.VyalikNA.NetCoreWebAppLibrary.DataModels.People", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Books")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Number")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("People");
                });
#pragma warning restore 612, 618
        }
    }
}
