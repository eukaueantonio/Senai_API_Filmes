﻿// <auto-generated />
using System;
using API_Filmes_SENAI.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace API_Filmes_SENAI.Migrations
{
    [DbContext(typeof(Filmes_Context))]
    partial class Filmes_ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("API_Filmes_SENAI.Domains.Filme", b =>
                {
                    b.Property<Guid>("IdFilme")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdGenero")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)");

                    b.HasKey("IdFilme");

                    b.HasIndex("IdGenero");

                    b.ToTable("Filme");
                });

            modelBuilder.Entity("API_Filmes_SENAI.Domains.Usuario", b =>
                {
                    b.Property<Guid>("IdUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("VARCHAR(60)");

                    b.HasKey("IdUsuario");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("API_Filmes_SENAI.NovaPasta.Genero", b =>
                {
                    b.Property<Guid>("IdGenero")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("VARCHAR(30)");

                    b.HasKey("IdGenero");

                    b.ToTable("Genero");
                });

            modelBuilder.Entity("API_Filmes_SENAI.Domains.Filme", b =>
                {
                    b.HasOne("API_Filmes_SENAI.NovaPasta.Genero", "Genero")
                        .WithMany()
                        .HasForeignKey("IdGenero")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genero");
                });
#pragma warning restore 612, 618
        }
    }
}
