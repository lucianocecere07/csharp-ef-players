﻿// <auto-generated />
using CSharpEntityFrameworkPlayers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CSharpEntityFrameworkPlayers.Migrations
{
    [DbContext(typeof(SportContext))]
    [Migration("20221222134247_CreaDataBase")]
    partial class CreaDataBase
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CSharpEntityFrameworkPlayers.Player", b =>
                {
                    b.Property<int>("PlayerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PlayerId"));

                    b.Property<int>("Match")
                        .HasColumnType("int")
                        .HasColumnName("partite_giocate");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("nome");

                    b.Property<int>("Score")
                        .HasColumnType("int")
                        .HasColumnName("punteggio");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("cognome");

                    b.Property<int>("Win")
                        .HasColumnType("int")
                        .HasColumnName("partite_vinte");

                    b.HasKey("PlayerId");

                    b.ToTable("players");
                });
#pragma warning restore 612, 618
        }
    }
}
