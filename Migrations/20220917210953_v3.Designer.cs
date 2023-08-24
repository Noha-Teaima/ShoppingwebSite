﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using project.Models;

#nullable disable

namespace project.Migrations
{
    [DbContext(typeof(myDbContext))]
    [Migration("20220917210953_v3")]
    partial class v3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("project.Models.Clothes", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("img")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("price")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("clothes");
                });

            modelBuilder.Entity("project.Models.Shoes", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("img")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("price")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("shoes");
                });

            modelBuilder.Entity("project.Models.User", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<int>("age")
                        .HasColumnType("int");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("password")
                        .HasColumnType("int");

                    b.Property<int>("phone")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("user");
                });

            modelBuilder.Entity("project.Models.UserClothes", b =>
                {
                    b.Property<int?>("userId")
                        .HasColumnType("int")
                        .HasColumnOrder(1);

                    b.Property<int>("clothesId")
                        .HasColumnType("int")
                        .HasColumnOrder(2);

                    b.HasKey("userId", "clothesId");

                    b.HasIndex("clothesId");

                    b.ToTable("userClothes");
                });

            modelBuilder.Entity("project.Models.UserShoes", b =>
                {
                    b.Property<int?>("userId")
                        .HasColumnType("int")
                        .HasColumnOrder(2);

                    b.Property<int>("shoesId")
                        .HasColumnType("int")
                        .HasColumnOrder(1);

                    b.HasKey("userId", "shoesId");

                    b.HasIndex("shoesId");

                    b.ToTable("userShoes");
                });

            modelBuilder.Entity("project.Models.UserClothes", b =>
                {
                    b.HasOne("project.Models.Clothes", "clothes")
                        .WithMany()
                        .HasForeignKey("clothesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("project.Models.User", "user")
                        .WithMany()
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("clothes");

                    b.Navigation("user");
                });

            modelBuilder.Entity("project.Models.UserShoes", b =>
                {
                    b.HasOne("project.Models.Shoes", "shoes")
                        .WithMany()
                        .HasForeignKey("shoesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("project.Models.User", "user")
                        .WithMany()
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("shoes");

                    b.Navigation("user");
                });
#pragma warning restore 612, 618
        }
    }
}
