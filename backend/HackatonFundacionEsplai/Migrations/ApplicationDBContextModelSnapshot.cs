﻿// <auto-generated />
using HackatonFundacionEsplai.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HackatonFundacionEsplai.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    partial class ApplicationDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HackatonFundacionEsplai.Entities.Country", b =>
                {
                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("BiocapacityDeficit")
                        .HasPrecision(2)
                        .HasColumnType("decimal(2,2)");

                    b.Property<decimal>("CarbonFootprint")
                        .HasPrecision(2)
                        .HasColumnType("decimal(2,2)");

                    b.Property<decimal>("CountriesRequired")
                        .HasPrecision(2)
                        .HasColumnType("decimal(2,2)");

                    b.Property<decimal>("Cropland")
                        .HasPrecision(2)
                        .HasColumnType("decimal(2,2)");

                    b.Property<decimal>("CroplandFootprint")
                        .HasPrecision(2)
                        .HasColumnType("decimal(2,2)");

                    b.Property<string>("DataQuality")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("nvarchar(2)");

                    b.Property<decimal>("EarthRequired")
                        .HasPrecision(2)
                        .HasColumnType("decimal(2,2)");

                    b.Property<decimal>("FishFootprint")
                        .HasPrecision(2)
                        .HasColumnType("decimal(2,2)");

                    b.Property<decimal>("FishingWater")
                        .HasPrecision(2)
                        .HasColumnType("decimal(2,2)");

                    b.Property<decimal>("ForestFootprint")
                        .HasPrecision(2)
                        .HasColumnType("decimal(2,2)");

                    b.Property<decimal>("ForestLand")
                        .HasPrecision(2)
                        .HasColumnType("decimal(2,2)");

                    b.Property<string>("GDP")
                        .IsRequired()
                        .HasPrecision(2)
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("GrazingLand")
                        .HasPrecision(2)
                        .HasColumnType("decimal(2,2)");

                    b.Property<decimal>("GrazzingFootprint")
                        .HasPrecision(2)
                        .HasColumnType("decimal(2,2)");

                    b.Property<decimal>("HDI")
                        .HasPrecision(2)
                        .HasColumnType("decimal(2,2)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("Population")
                        .HasPrecision(2)
                        .HasColumnType("decimal(2,2)");

                    b.Property<int>("RegionId")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalBiocapacity")
                        .HasPrecision(2)
                        .HasColumnType("decimal(2,2)");

                    b.Property<decimal>("TotalEcological")
                        .HasPrecision(2)
                        .HasColumnType("decimal(2,2)");

                    b.Property<decimal>("UrbanLand")
                        .HasPrecision(2)
                        .HasColumnType("decimal(2,2)");

                    b.HasKey("Name");

                    b.HasIndex("RegionId");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("HackatonFundacionEsplai.Entities.Region", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID");

                    b.ToTable("Regions");
                });

            modelBuilder.Entity("HackatonFundacionEsplai.Entities.Country", b =>
                {
                    b.HasOne("HackatonFundacionEsplai.Entities.Region", null)
                        .WithMany("Countries")
                        .HasForeignKey("RegionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HackatonFundacionEsplai.Entities.Region", b =>
                {
                    b.Navigation("Countries");
                });
#pragma warning restore 612, 618
        }
    }
}