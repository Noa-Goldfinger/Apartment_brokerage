﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Solid.Data;

#nullable disable

namespace Solid.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.27")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ApartmentBrokerage.Entities.Apartment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumApartment")
                        .HasColumnType("int");

                    b.Property<int>("NumBuilding")
                        .HasColumnType("int");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("apartmentOwnerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("apartmentOwnerId");

                    b.ToTable("ApartmentsList");
                });

            modelBuilder.Entity("ApartmentBrokerage.Entities.ApartmentOwner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Phone")
                        .HasColumnType("int");

                    b.Property<int?>("SellId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SellId");

                    b.ToTable("ApartmentOwnersList");
                });

            modelBuilder.Entity("ApartmentBrokerage.Entities.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Phone")
                        .HasColumnType("int");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ClientsList");
                });

            modelBuilder.Entity("Solid.Core.Entities.Sell", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("BuyerId")
                        .HasColumnType("int");

                    b.Property<int>("Payment")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BuyerId");

                    b.ToTable("SellsList");
                });

            modelBuilder.Entity("ApartmentBrokerage.Entities.Apartment", b =>
                {
                    b.HasOne("ApartmentBrokerage.Entities.ApartmentOwner", "apartmentOwner")
                        .WithMany("Apartment")
                        .HasForeignKey("apartmentOwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("apartmentOwner");
                });

            modelBuilder.Entity("ApartmentBrokerage.Entities.ApartmentOwner", b =>
                {
                    b.HasOne("Solid.Core.Entities.Sell", null)
                        .WithMany("Seller")
                        .HasForeignKey("SellId");
                });

            modelBuilder.Entity("Solid.Core.Entities.Sell", b =>
                {
                    b.HasOne("ApartmentBrokerage.Entities.Client", "Buyer")
                        .WithMany("Sell")
                        .HasForeignKey("BuyerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Buyer");
                });

            modelBuilder.Entity("ApartmentBrokerage.Entities.ApartmentOwner", b =>
                {
                    b.Navigation("Apartment");
                });

            modelBuilder.Entity("ApartmentBrokerage.Entities.Client", b =>
                {
                    b.Navigation("Sell");
                });

            modelBuilder.Entity("Solid.Core.Entities.Sell", b =>
                {
                    b.Navigation("Seller");
                });
#pragma warning restore 612, 618
        }
    }
}