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
    [Migration("20231130133221_added_apprartment_4")]
    partial class added_apprartment_4
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

                    b.HasData(
                        new
                        {
                            Id = new Guid("b1e70dd0-5bad-4ef1-8945-ff03ca919baa"),
                            City = "Kristianstad",
                            County = "Skåne",
                            Number = 12,
                            NumberAffix = "C",
                            PostalCode = "291 50",
                            PropertyId = new Guid("5eba581f-1428-4630-bc95-f3e1b6ae02ca"),
                            Street = "Snapphanevägen"
                        },
                        new
                        {
                            Id = new Guid("0b06e800-bf7c-4d65-b00f-722f2280f5b9"),
                            City = "Kristianstad",
                            County = "Skåne",
                            Number = 18,
                            NumberAffix = "E",
                            PostalCode = "291 30",
                            PropertyId = new Guid("77113cee-6316-4ed3-8003-9eefa714d0fd"),
                            Street = "Blekingevägen"
                        },
                        new
                        {
                            Id = new Guid("3b915c92-bba9-48d4-84d5-c142f92a4d25"),
                            City = "Kristianstad",
                            County = "Skåne",
                            Number = 7,
                            NumberAffix = "B",
                            PostalCode = "291 21",
                            PropertyId = new Guid("dc69538b-3542-4177-bb33-498a2c4b3a91"),
                            Street = "Kanalgatan"
                        });
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

                    b.HasData(
                        new
                        {
                            Id = new Guid("24753fad-0fb9-4250-ab3a-07a5038efadc"),
                            AdvertText = "Detta är den fetaste lägenheten på marknaden. Inga djur, inga rökare, inga människor!",
                            AppartmentId = new Guid("cd80e77e-5815-4b4a-8ca7-45bf51dd42d3")
                        });
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

                    b.HasData(
                        new
                        {
                            Id = new Guid("7201b81b-3d99-4476-ac3c-1f4518b7e9f9"),
                            AddressId = new Guid("b1e70dd0-5bad-4ef1-8945-ff03ca919baa"),
                            LMNumber = 345612,
                            ObjectNumber = "9876-5432",
                            PropertyId = new Guid("5eba581f-1428-4630-bc95-f3e1b6ae02ca"),
                            QueueRuleId = new Guid("9aa02117-7045-4633-9297-e8ead75035cf")
                        },
                        new
                        {
                            Id = new Guid("cd80e77e-5815-4b4a-8ca7-45bf51dd42d3"),
                            AddressId = new Guid("0b06e800-bf7c-4d65-b00f-722f2280f5b9"),
                            AdvertId = new Guid("1b8c7aee-fcf2-45c7-8c96-ef0325f441f5"),
                            LMNumber = 345612,
                            ObjectNumber = "9876-5432",
                            PropertyId = new Guid("77113cee-6316-4ed3-8003-9eefa714d0fd"),
                            QueueRuleId = new Guid("e6d45b39-2c2c-4880-ba9e-ffd3c52c4ebb")
                        },
                        new
                        {
                            Id = new Guid("213c995a-0463-4030-aa10-227b39e989e7"),
                            AddressId = new Guid("3b915c92-bba9-48d4-84d5-c142f92a4d25"),
                            LMNumber = 345612,
                            ObjectNumber = "9876-5432",
                            PropertyId = new Guid("77113cee-6316-4ed3-8003-9eefa714d0fd"),
                            QueueRuleId = new Guid("6055f821-bf36-4a3a-981d-3e80236adcb0")
                        });
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

                    b.HasData(
                        new
                        {
                            Id = new Guid("5eba581f-1428-4630-bc95-f3e1b6ae02ca"),
                            LMNumber = 123456,
                            ObjectNumber = "1234-5678",
                            QueueRuleId = new Guid("9aa02117-7045-4633-9297-e8ead75035cf")
                        },
                        new
                        {
                            Id = new Guid("77113cee-6316-4ed3-8003-9eefa714d0fd"),
                            LMNumber = 234561,
                            ObjectNumber = "8765-4321",
                            QueueRuleId = new Guid("e6d45b39-2c2c-4880-ba9e-ffd3c52c4ebb")
                        },
                        new
                        {
                            Id = new Guid("dc69538b-3542-4177-bb33-498a2c4b3a91"),
                            LMNumber = 345612,
                            ObjectNumber = "9876-5432",
                            QueueRuleId = new Guid("6055f821-bf36-4a3a-981d-3e80236adcb0")
                        });
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

                    b.HasData(
                        new
                        {
                            Id = new Guid("9aa02117-7045-4633-9297-e8ead75035cf"),
                            Name = "Köregel 1"
                        },
                        new
                        {
                            Id = new Guid("e6d45b39-2c2c-4880-ba9e-ffd3c52c4ebb"),
                            Name = "Köregel 2"
                        },
                        new
                        {
                            Id = new Guid("6055f821-bf36-4a3a-981d-3e80236adcb0"),
                            Name = "Köregel 3"
                        });
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
#pragma warning restore 612, 618
        }
    }
}
