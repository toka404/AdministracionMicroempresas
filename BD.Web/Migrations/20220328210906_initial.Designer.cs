﻿// <auto-generated />
using BD.Web.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BD.Web.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20220328210906_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.15");

            modelBuilder.Entity("BD.Web.Data.provincia", b =>
                {
                    b.Property<int>("ID_PROVINCIA")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("NOMBRE_PROVINCIA")
                        .HasColumnType("text");

                    b.HasKey("ID_PROVINCIA");

                    b.ToTable("provincia");
                });
#pragma warning restore 612, 618
        }
    }
}
