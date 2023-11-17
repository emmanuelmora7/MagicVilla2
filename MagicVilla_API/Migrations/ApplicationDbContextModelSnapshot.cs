﻿// <auto-generated />
using System;
using MagicVilla_API.Datos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MagicVilla_API.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MagicVilla_API.Modelos.Villa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Amenidad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Detalle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaActualizacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImagenUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Tarifa")
                        .HasColumnType("float");

                    b.Property<int>("metrosCuadrados")
                        .HasColumnType("int");

                    b.Property<int>("ocupantes")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Villas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Amenidad = "",
                            Detalle = "Detalle de la Villa",
                            FechaActualizacion = new DateTime(2023, 11, 16, 18, 43, 43, 176, DateTimeKind.Local).AddTicks(7810),
                            FechaCreacion = new DateTime(2023, 11, 16, 18, 43, 43, 176, DateTimeKind.Local).AddTicks(7822),
                            ImagenUrl = "",
                            Nombre = "Emmanuel",
                            Tarifa = 100.0,
                            metrosCuadrados = 40,
                            ocupantes = 3
                        },
                        new
                        {
                            Id = 2,
                            Amenidad = "",
                            Detalle = "Detalle de la Villa11",
                            FechaActualizacion = new DateTime(2023, 11, 16, 18, 43, 43, 176, DateTimeKind.Local).AddTicks(7826),
                            FechaCreacion = new DateTime(2023, 11, 16, 18, 43, 43, 176, DateTimeKind.Local).AddTicks(7827),
                            ImagenUrl = "",
                            Nombre = "Dana",
                            Tarifa = 150.0,
                            metrosCuadrados = 50,
                            ocupantes = 4
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
