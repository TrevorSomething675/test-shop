﻿// <auto-generated />
using System;
using JijaShop.Api.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace JijaShop.Api.Migrations
{
    [DbContext(typeof(MainContext))]
    partial class MainContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("JijaShop.Api.Data.Models.Entities.Admin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("Id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("AdminEmail")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("AdminIp")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("AdminName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("AdminPassword")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<byte[]>("AdminPasswordHash")
                        .HasColumnType("bytea");

                    b.Property<byte[]>("AdminPasswordSalt")
                        .HasColumnType("bytea");

                    b.HasKey("Id");

                    b.ToTable("Admin");
                });

            modelBuilder.Entity("JijaShop.Api.Data.Models.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("Id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("ProductDetailsId")
                        .HasColumnType("integer");

                    b.Property<int>("ProductOffersId")
                        .HasColumnType("integer");

                    b.Property<int?>("Quantity")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("ProductDetailsId");

                    b.HasIndex("ProductOffersId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("JijaShop.Api.Data.Models.Entities.ProductDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("Id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<decimal?>("OldPrice")
                        .HasColumnType("numeric");

                    b.Property<decimal?>("Price")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.ToTable("ProductDetails");
                });

            modelBuilder.Entity("JijaShop.Api.Data.Models.Entities.ProductOffers", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("Id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsHitOffer")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsNewOffer")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.ToTable("ProductOffers");
                });

            modelBuilder.Entity("JijaShop.Api.Data.Models.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("Id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("UserAge")
                        .HasColumnType("integer");

                    b.Property<string>("UserEmail")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<byte[]>("UserPasswordHash")
                        .HasColumnType("bytea");

                    b.Property<byte[]>("UserPasswordSalt")
                        .HasColumnType("bytea");

                    b.Property<string>("UserPhone")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("JijaShop.Api.Data.Models.Entities.Product", b =>
                {
                    b.HasOne("JijaShop.Api.Data.Models.Entities.ProductDetails", "ProductDetails")
                        .WithMany()
                        .HasForeignKey("ProductDetailsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("JijaShop.Api.Data.Models.Entities.ProductOffers", "ProductOffers")
                        .WithMany()
                        .HasForeignKey("ProductOffersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProductDetails");

                    b.Navigation("ProductOffers");
                });
#pragma warning restore 612, 618
        }
    }
}
