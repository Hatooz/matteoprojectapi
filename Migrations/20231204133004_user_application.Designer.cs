﻿// <auto-generated />
using System;
using MatteoRbProject.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MatteoRbProject.Migrations
{
    [DbContext(typeof(MatteoRbProjectContext))]
    [Migration("20231204133004_user_application")]
    partial class user_application
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MatteoRbProject.Models.Address", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("County")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<string>("NumberAffix")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("PropertyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PropertyId");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("MatteoRbProject.Models.Advert", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AdvertText")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("AppartmentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("PublishedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("RentalDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AppartmentId")
                        .IsUnique();

                    b.ToTable("Adverts");
                });

            modelBuilder.Entity("MatteoRbProject.Models.Appartment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AddressId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("AdvertId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("LMNumber")
                        .HasColumnType("int");

                    b.Property<string>("ObjectNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("PropertyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("QueueRuleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.HasIndex("PropertyId");

                    b.HasIndex("QueueRuleId");

                    b.ToTable("Appartments");
                });

            modelBuilder.Entity("MatteoRbProject.Models.Application", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AppartmentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("AppartmentId");

                    b.HasIndex("UserId");

                    b.ToTable("Applications");
                });

            modelBuilder.Entity("MatteoRbProject.Models.Property", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("LMNumber")
                        .HasColumnType("int");

                    b.Property<string>("ObjectNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("QueueRuleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("QueueRuleId");

                    b.ToTable("Properties");
                });

            modelBuilder.Entity("MatteoRbProject.Models.QueueRule", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("QueueRules");
                });

            modelBuilder.Entity("MatteoRbProject.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("MatteoRbProject.Models.Address", b =>
                {
                    b.HasOne("MatteoRbProject.Models.Property", "Property")
                        .WithMany("Addresses")
                        .HasForeignKey("PropertyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Property");
                });

            modelBuilder.Entity("MatteoRbProject.Models.Advert", b =>
                {
                    b.HasOne("MatteoRbProject.Models.Appartment", "Appartment")
                        .WithOne("Advert")
                        .HasForeignKey("MatteoRbProject.Models.Advert", "AppartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Appartment");
                });

            modelBuilder.Entity("MatteoRbProject.Models.Appartment", b =>
                {
                    b.HasOne("MatteoRbProject.Models.Address", "Address")
                        .WithMany("Appartments")
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("MatteoRbProject.Models.Property", "Property")
                        .WithMany("Appartments")
                        .HasForeignKey("PropertyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MatteoRbProject.Models.QueueRule", "QueueRule")
                        .WithMany("Appartments")
                        .HasForeignKey("QueueRuleId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Address");

                    b.Navigation("Property");

                    b.Navigation("QueueRule");
                });

            modelBuilder.Entity("MatteoRbProject.Models.Application", b =>
                {
                    b.HasOne("MatteoRbProject.Models.Appartment", "Appartment")
                        .WithMany("Applications")
                        .HasForeignKey("AppartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MatteoRbProject.Models.User", "User")
                        .WithMany("Applications")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Appartment");

                    b.Navigation("User");
                });

            modelBuilder.Entity("MatteoRbProject.Models.Property", b =>
                {
                    b.HasOne("MatteoRbProject.Models.QueueRule", "QueueRule")
                        .WithMany("Properties")
                        .HasForeignKey("QueueRuleId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("QueueRule");
                });

            modelBuilder.Entity("MatteoRbProject.Models.Address", b =>
                {
                    b.Navigation("Appartments");
                });

            modelBuilder.Entity("MatteoRbProject.Models.Appartment", b =>
                {
                    b.Navigation("Advert");

                    b.Navigation("Applications");
                });

            modelBuilder.Entity("MatteoRbProject.Models.Property", b =>
                {
                    b.Navigation("Addresses");

                    b.Navigation("Appartments");
                });

            modelBuilder.Entity("MatteoRbProject.Models.QueueRule", b =>
                {
                    b.Navigation("Appartments");

                    b.Navigation("Properties");
                });

            modelBuilder.Entity("MatteoRbProject.Models.User", b =>
                {
                    b.Navigation("Applications");
                });
#pragma warning restore 612, 618
        }
    }
}