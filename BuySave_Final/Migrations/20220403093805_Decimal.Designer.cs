﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BuySave_Final.Migrations
{
    [DbContext(typeof(BuySave_FinalContextdb))]
    [Migration("20220403093805_Decimal")]
    partial class Decimal
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.15")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BuySave_Final.Models.Catagory", b =>
                {
                    b.Property<int>("CatagoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CatagoryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CatagoryID");

                    b.ToTable("Catagory");
                });

            modelBuilder.Entity("BuySave_Final.Models.Country", b =>
                {
                    b.Property<int>("CountryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CountryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CountryID");

                    b.ToTable("Country");
                });

            modelBuilder.Entity("BuySave_Final.Models.Product", b =>
                {
                    b.Property<int>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CatagoryID")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ProductName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductID");

                    b.HasIndex("CatagoryID");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("BuySave_Final.Models.Review", b =>
                {
                    b.Property<int>("ReviewID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ItemRating")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.Property<string>("ReviewText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.Property<int>("WebsiteRating")
                        .HasColumnType("int");

                    b.Property<string>("WebsiteURL")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ReviewID");

                    b.HasIndex("ProductID");

                    b.HasIndex("UserID");

                    b.ToTable("Review");
                });

            modelBuilder.Entity("BuySave_Final.Models.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CountryID")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserID");

                    b.HasIndex("CountryID");

                    b.ToTable("User");
                });

            modelBuilder.Entity("BuySave_Final.Models.Product", b =>
                {
                    b.HasOne("BuySave_Final.Models.Catagory", "Catagory")
                        .WithMany("Product")
                        .HasForeignKey("CatagoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Catagory");
                });

            modelBuilder.Entity("BuySave_Final.Models.Review", b =>
                {
                    b.HasOne("BuySave_Final.Models.Product", "Product")
                        .WithMany("Review")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BuySave_Final.Models.User", "User")
                        .WithMany("Review")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BuySave_Final.Models.User", b =>
                {
                    b.HasOne("BuySave_Final.Models.Country", "Country")
                        .WithMany("User")
                        .HasForeignKey("CountryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("BuySave_Final.Models.Catagory", b =>
                {
                    b.Navigation("Product");
                });

            modelBuilder.Entity("BuySave_Final.Models.Country", b =>
                {
                    b.Navigation("User");
                });

            modelBuilder.Entity("BuySave_Final.Models.Product", b =>
                {
                    b.Navigation("Review");
                });

            modelBuilder.Entity("BuySave_Final.Models.User", b =>
                {
                    b.Navigation("Review");
                });
#pragma warning restore 612, 618
        }
    }
}
