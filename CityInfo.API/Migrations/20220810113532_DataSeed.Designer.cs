﻿// <auto-generated />
using CityInfo.API.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CityInfo.API.Migrations
{
    [DbContext(typeof(CityInfoContext))]
    [Migration("20220810113532_DataSeed")]
    partial class DataSeed
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.7");

            modelBuilder.Entity("CityInfo.API.Entities.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Cities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "The one with that big fort",
                            Name = "New Delhi"
                        },
                        new
                        {
                            Id = 2,
                            Description = "The one which has lot of money",
                            Name = "Mumbai"
                        },
                        new
                        {
                            Id = 3,
                            Description = "The one which has a famous bridge",
                            Name = "Kolkata"
                        });
                });

            modelBuilder.Entity("CityInfo.API.Entities.PointOfInterest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CityId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("PointsOfInterest");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CityId = 1,
                            Description = "The most visited place in New Delhi. Built by Mughal emperor Shahjahan",
                            Name = "Red fort"
                        },
                        new
                        {
                            Id = 2,
                            CityId = 1,
                            Description = "The minar built by Kutubuddin Ebak",
                            Name = "Kutubminar"
                        },
                        new
                        {
                            Id = 3,
                            CityId = 2,
                            Description = "The big cinema stars can be found here",
                            Name = "Film Industries"
                        },
                        new
                        {
                            Id = 4,
                            CityId = 2,
                            Description = "One of India's wealthies hotel",
                            Name = "Taj Hotel"
                        },
                        new
                        {
                            Id = 5,
                            CityId = 3,
                            Description = "The bridge is famous in india",
                            Name = "Howrah bridge"
                        },
                        new
                        {
                            Id = 6,
                            CityId = 3,
                            Description = "Large marvel building in central Kolkata",
                            Name = "Victoria Memorial"
                        });
                });

            modelBuilder.Entity("CityInfo.API.Entities.PointOfInterest", b =>
                {
                    b.HasOne("CityInfo.API.Entities.City", "City")
                        .WithMany("PointsOfInterest")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("CityInfo.API.Entities.City", b =>
                {
                    b.Navigation("PointsOfInterest");
                });
#pragma warning restore 612, 618
        }
    }
}
