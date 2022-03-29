﻿// <auto-generated />
using System;
using BD.Web.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BD.Web.Migrations
{
    [DbContext(typeof(MyDbContext))]
    partial class MyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.12");

            modelBuilder.Entity("BD.Web.Data.Categoria", b =>
                {
                    b.Property<int>("Id_Categoria")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nombre_Categoria")
                        .HasColumnType("text");

                    b.HasKey("Id_Categoria");

                    b.ToTable("Categoria");
                });

            modelBuilder.Entity("BD.Web.Data.Detalle_Factura", b =>
                {
                    b.Property<int>("Id_Cabecera")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<decimal>("Cantidad_Vendida")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<int>("Id_Producto")
                        .HasColumnType("int");

                    b.Property<decimal>("Precio_Total")
                        .HasColumnType("decimal(18, 2)");

                    b.HasKey("Id_Cabecera");

                    b.ToTable("Detalle_Factura");
                });

            modelBuilder.Entity("BD.Web.Data.Emprendimiento", b =>
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

            modelBuilder.Entity("BD.Web.Data.Factura_Cabecera", b =>
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

                    b.Property<decimal>("Iva_Cero")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<decimal>("Iva_Total")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<string>("Nombre_Cliente")
                        .HasColumnType("text");

                    b.Property<int>("Nro_Factura")
                        .HasColumnType("int");

                    b.Property<decimal>("Subtotal")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<string>("Telefono_Cliente")
                        .HasColumnType("text");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(18, 2)");

                    b.HasKey("Id_Cabecera");

                    b.ToTable("Factura_Cabecera");
                });

            modelBuilder.Entity("BD.Web.Data.Iva", b =>
                {
                    b.Property<int>("Id_Iva")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<decimal>("Valor_Iva")
                        .HasColumnType("decimal(18, 2)");

                    b.HasKey("Id_Iva");

                    b.ToTable("Iva");
                });

            modelBuilder.Entity("BD.Web.Data.Producto", b =>
                {
                    b.Property<int>("Id_Producto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .HasColumnType("text");

                    b.Property<DateTime>("Fecha_Caducidad")
                        .HasColumnType("datetime");

                    b.Property<string>("Foto")
                        .HasColumnType("text");

                    b.Property<int>("Id_Emprendimiento")
                        .HasColumnType("int");

                    b.Property<string>("Iva")
                        .HasColumnType("text");

                    b.Property<string>("Nombre_Producto")
                        .HasColumnType("text");

                    b.Property<decimal>("Precio_Fabricacion")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<decimal>("Precio_Venta")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.HasKey("Id_Producto");

                    b.ToTable("Producto");
                });

            modelBuilder.Entity("BD.Web.Data.Producto_Tiene_Proveedor", b =>
                {
                    b.Property<int>("Id_Producto")
                        .HasColumnType("int");

                    b.Property<int>("Id_Proveedor")
                        .HasColumnType("int");

                    b.ToTable("Producto_Tiene_Proveedor");
                });

            modelBuilder.Entity("BD.Web.Data.Proveedor", b =>
                {
                    b.Property<int>("Id_Proveedor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("E_Mail_Proveedor")
                        .HasColumnType("text");

                    b.Property<int>("Id_Provincia")
                        .HasColumnType("int");

                    b.Property<string>("Nombre_Proveedor")
                        .HasColumnType("text");

                    b.Property<string>("Producto")
                        .HasColumnType("text");

                    b.Property<string>("RUC")
                        .HasColumnType("text");

                    b.Property<string>("Telefono")
                        .HasColumnType("text");

                    b.HasKey("Id_Proveedor");

                    b.ToTable("Proveedor");
                });

            modelBuilder.Entity("BD.Web.Data.Provincia", b =>
                {
                    b.Property<int>("Id_Provincia")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nombre_Provincia")
                        .HasColumnType("text");

                    b.HasKey("Id_Provincia");

                    b.ToTable("Provincia");
                });

            modelBuilder.Entity("BD.Web.Data.Usuario", b =>
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

                    b.HasKey("Id_Usuario");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("BD.Web.Data.Usuario_Tiene_Emprendimientos", b =>
                {
                    b.Property<int>("Id_Emprendimiento")
                        .HasColumnType("int");

                    b.Property<int>("Id_Usuario")
                        .HasColumnType("int");

                    b.ToTable("Usuario_Tiene_Emprendimientos");
                });
#pragma warning restore 612, 618
        }
    }
}
