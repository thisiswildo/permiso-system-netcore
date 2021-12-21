﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PermisoSystem.Data;

namespace PermisoSystem.Api.Migrations
{
    [DbContext(typeof(PermisoSystemContext))]
    partial class PermisoSystemContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PermisoSystem.Data.Entities.Permiso", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ApellidosEmpleado")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<DateTime>("FechaPermiso")
                        .HasColumnType("datetime2");

                    b.Property<string>("NombreEmpleado")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("TipoPermisoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TipoPermisoId");

                    b.ToTable("Permiso");
                });

            modelBuilder.Entity("PermisoSystem.Data.Entities.TipoPermiso", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("TipoPermiso");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Descripcion = "Enfermedad"
                        },
                        new
                        {
                            Id = 2,
                            Descripcion = "Diligencias"
                        },
                        new
                        {
                            Id = 3,
                            Descripcion = "Otros"
                        });
                });

            modelBuilder.Entity("PermisoSystem.Data.Entities.Permiso", b =>
                {
                    b.HasOne("PermisoSystem.Data.Entities.TipoPermiso", "TipoPermiso")
                        .WithMany()
                        .HasForeignKey("TipoPermisoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
