﻿// <auto-generated />
using System;
using APIVacunas_Restaurante.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace APIVacunas_Restaurante.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("APIVacunas_Restaurante.Models.Usuario", b =>
                {
                    b.Property<string>("Carnet")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("NombreCompleto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Carnet");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("APIVacunas_Restaurante.Models.Vacuna", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Carnet")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Dosis")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaDeVacunacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UsuarioCarnet")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioCarnet");

                    b.ToTable("Vacuna");
                });

            modelBuilder.Entity("APIVacunas_Restaurante.Models.Vacuna", b =>
                {
                    b.HasOne("APIVacunas_Restaurante.Models.Usuario", null)
                        .WithMany("Vacunas")
                        .HasForeignKey("UsuarioCarnet");
                });

            modelBuilder.Entity("APIVacunas_Restaurante.Models.Usuario", b =>
                {
                    b.Navigation("Vacunas");
                });
#pragma warning restore 612, 618
        }
    }
}
