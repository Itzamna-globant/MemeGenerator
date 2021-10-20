﻿// <auto-generated />
using MemeGen.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NetTopologySuite.Geometries;

namespace MemeGen.Infrastructure.Persistence.Migrations
{
    [DbContext(typeof(MemeDbContext))]
    [Migration("20211020225517_MemeTemplate_Seed")]
    partial class MemeTemplate_Seed
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MemeGen.Domain.Entities.MemeTemplate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("TextRectangleMaxHeight")
                        .HasColumnType("int");

                    b.Property<int>("TextRectangleMaxWidth")
                        .HasColumnType("int");

                    b.Property<Point>("TextRectangleOrigin")
                        .IsRequired()
                        .HasColumnType("geography");

                    b.HasKey("Id");

                    b.ToTable("MemeTemplates");

                    b.HasData(
                        new
                        {
                            Id = -1,
                            Name = "Test",
                            TextRectangleMaxHeight = 250,
                            TextRectangleMaxWidth = 500,
                            TextRectangleOrigin = (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (10 10)")
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
