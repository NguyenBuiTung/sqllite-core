﻿// <auto-generated />
using System;
using CometBarCode;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CometBarCode.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240924093014_RemoveModelColumn")]
    partial class RemoveModelColumn
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.8");

            modelBuilder.Entity("CometBarCode.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("CometBarCode.CodeEntry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("AccountId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsDuplicate")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsWrongType")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("ScanTime")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.ToTable("CodeEntries");
                });

            modelBuilder.Entity("CometBarCode.Setting", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("LastUpdated")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProductType")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Settings");
                });

            modelBuilder.Entity("CometBarCode.CodeEntry", b =>
                {
                    b.HasOne("CometBarCode.Account", null)
                        .WithMany("CodeEntries")
                        .HasForeignKey("AccountId");
                });

            modelBuilder.Entity("CometBarCode.Account", b =>
                {
                    b.Navigation("CodeEntries");
                });
#pragma warning restore 612, 618
        }
    }
}
