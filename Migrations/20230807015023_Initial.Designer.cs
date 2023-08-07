﻿// <auto-generated />
using KymaniApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace KymaniApi.Migrations
{
    [DbContext(typeof(KymaniApiContext))]
    [Migration("20230807015023_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("KymaniApi.Models.Kymani", b =>
                {
                    b.Property<int>("KymaniId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Mood")
                        .HasColumnType("longtext");

                    b.Property<int>("PowerLevel")
                        .HasColumnType("int");

                    b.HasKey("KymaniId");

                    b.ToTable("Kymanis");
                });
#pragma warning restore 612, 618
        }
    }
}
