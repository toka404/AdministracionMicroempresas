﻿// <auto-generated />
using System;
using Banding.Repository.DataBaseContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Banding.Repository.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20220506050103_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.16");

            modelBuilder.Entity("Banding.Core.Models.Entities.MySql.Categoria", b =>
                {
                    b.Property<int>("Id_Categoria")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nombre_Categoria")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.HasKey("Id_Categoria");

                    b.ToTable("Categoria");
                });

            modelBuilder.Entity("Banding.Core.Models.Entities.MySql.Detalle_Factura", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Cantidad_Vendida")
                        .HasColumnType("int");

                    b.Property<int?>("Factura_CabeceraId_Cabecera")
                        .HasColumnType("int");

                    b.Property<int>("Id_Cabecera")
                        .HasColumnType("int");

                    b.Property<int>("Id_Producto")
                        .HasColumnType("int");

                    b.Property<double>("Precio_Total")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.HasIndex("Factura_CabeceraId_Cabecera");

                    b.ToTable("Detalle_Factura");
                });

            modelBuilder.Entity("Banding.Core.Models.Entities.MySql.Emprendimiento", b =>
                {
                    b.Property<int>("Id_Emprendimiento")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descripcion_Emprendimiento")
                        .HasColumnType("text");

                    b.Property<int>("Id_Categoria")
                        .HasColumnType("int");

                    b.Property<string>("Logo")
                        .HasColumnType("text");

                    b.Property<string>("Nombre_Emprendimiento")
                        .HasColumnType("text");

                    b.HasKey("Id_Emprendimiento");

                    b.ToTable("Emprendimiento");
                });

            modelBuilder.Entity("Banding.Core.Models.Entities.MySql.Factura_Cabecera", b =>
                {
                    b.Property<int>("Id_Cabecera")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Cedula_Cliente")
                        .HasColumnType("text");

                    b.Property<string>("Direccion_Cliente")
                        .HasColumnType("text");

                    b.Property<DateTime>("Fecha_Cabecera")
                        .HasColumnType("datetime");

                    b.Property<int>("Id_Iva")
                        .HasColumnType("int");

                    b.Property<int>("Iva_Cero")
                        .HasColumnType("int");

                    b.Property<double>("Iva_Total")
                        .HasColumnType("double");

                    b.Property<string>("Nombre_Cliente")
                        .HasColumnType("text");

                    b.Property<int>("Nro_Factura")
                        .HasColumnType("int");

                    b.Property<double>("Subtotal")
                        .HasColumnType("double");

                    b.Property<string>("Telefono_Cliente")
                        .HasColumnType("text");

                    b.Property<double>("Total")
                        .HasColumnType("double");

                    b.HasKey("Id_Cabecera");

                    b.ToTable("Factura_Cabecera");
                });

            modelBuilder.Entity("Banding.Core.Models.Entities.MySql.Iva", b =>
                {
                    b.Property<int>("Id_Iva")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Valor_Iva")
                        .HasColumnType("int");

                    b.HasKey("Id_Iva");

                    b.ToTable("Iva");
                });

            modelBuilder.Entity("Banding.Core.Models.Entities.MySql.Producto", b =>
                {
                    b.Property<int>("Id_Producto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)");

                    b.Property<string>("Email_Enviado")
                        .HasColumnType("text");

                    b.Property<DateTime?>("Fecha_Caducidad")
                        .HasColumnType("datetime");

                    b.Property<string>("Foto")
                        .HasColumnType("text");

                    b.Property<int>("Id_Emprendimiento")
                        .HasColumnType("int");

                    b.Property<string>("Iva")
                        .HasColumnType("text");

                    b.Property<string>("Nombre_Producto")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("varchar(40)");

                    b.Property<double>("Precio_Fabricacion")
                        .HasColumnType("double");

                    b.Property<double>("Precio_Venta")
                        .HasColumnType("double");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.Property<int>("Stock_Minimo")
                        .HasColumnType("int");

                    b.HasKey("Id_Producto");

                    b.ToTable("Producto");
                });

            modelBuilder.Entity("Banding.Core.Models.Entities.MySql.Producto_Tiene_Proveedor", b =>
                {
                    b.Property<int>("Id_Producto")
                        .HasColumnType("int");

                    b.Property<int>("Id_Proveedor")
                        .HasColumnType("int");

                    b.ToTable("Producto_Tiene_Proveedor");
                });

            modelBuilder.Entity("Banding.Core.Models.Entities.MySql.Proveedor", b =>
                {
                    b.Property<int>("Id_Proveedor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("E_Mail_Proveedor")
                        .HasColumnType("text");

                    b.Property<int>("Id_Provincia")
                        .HasColumnType("int");

                    b.Property<string>("Nombre_Proveedor")
                        .HasMaxLength(40)
                        .HasColumnType("varchar(40)");

                    b.Property<string>("Producto")
                        .HasColumnType("text");

                    b.Property<string>("RUC")
                        .HasColumnType("text");

                    b.Property<string>("Telefono")
                        .HasColumnType("text");

                    b.HasKey("Id_Proveedor");

                    b.ToTable("Proveedor");
                });

            modelBuilder.Entity("Banding.Core.Models.Entities.MySql.Provincia", b =>
                {
                    b.Property<int>("Id_Provincia")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nombre_Provincia")
                        .HasColumnType("text");

                    b.HasKey("Id_Provincia");

                    b.ToTable("Provincia");
                });

            modelBuilder.Entity("Banding.Core.Models.Entities.MySql.Roles", b =>
                {
                    b.Property<int>("id_rol")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("nombre_rol")
                        .HasColumnType("text");

                    b.HasKey("id_rol");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Banding.Core.Models.Entities.MySql.Usuario", b =>
                {
                    b.Property<int>("Id_Usuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Apellido_Usuario")
                        .HasColumnType("text");

                    b.Property<string>("Celular")
                        .HasColumnType("text");

                    b.Property<string>("Contrasena")
                        .HasColumnType("text");

                    b.Property<string>("E_Mail")
                        .HasColumnType("text");

                    b.Property<int>("Id_Provincia")
                        .HasColumnType("int");

                    b.Property<string>("Nombre_Usuario")
                        .HasColumnType("text");

                    b.Property<string>("Username")
                        .HasColumnType("text");

                    b.Property<int>("id_emprendimiento")
                        .HasColumnType("int");

                    b.Property<int>("rol_id")
                        .HasColumnType("int");

                    b.HasKey("Id_Usuario");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("Banding.Core.Models.Entities.MySql.Usuario_Tiene_Emprendimientos", b =>
                {
                    b.Property<int>("Id_Emprendimiento")
                        .HasColumnType("int");

                    b.Property<int>("Id_Usuario")
                        .HasColumnType("int");

                    b.ToTable("Usuario_Tiene_Emprendimientos");
                });

            modelBuilder.Entity("Banding.Core.Models.Entities.MySql.Detalle_Factura", b =>
                {
                    b.HasOne("Banding.Core.Models.Entities.MySql.Factura_Cabecera", null)
                        .WithMany("Detalles")
                        .HasForeignKey("Factura_CabeceraId_Cabecera");
                });

            modelBuilder.Entity("Banding.Core.Models.Entities.MySql.Factura_Cabecera", b =>
                {
                    b.Navigation("Detalles");
                });
#pragma warning restore 612, 618
        }
    }
}