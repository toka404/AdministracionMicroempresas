﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace BD.Web.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categoria",
                columns: table => new
                {
                    Id_Categoria = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Nombre_Categoria = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoria", x => x.Id_Categoria);
                });

            migrationBuilder.CreateTable(
                name: "Detalle_Factura",
                columns: table => new
                {
                    Id_Cabecera = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Id_Producto = table.Column<int>(type: "int", nullable: false),
                    Cantidad_Vendida = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Precio_Total = table.Column<decimal>(type: "decimal(18, 2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Detalle_Factura", x => x.Id_Cabecera);
                });

            migrationBuilder.CreateTable(
                name: "Emprendimiento",
                columns: table => new
                {
                    Id_Emprendimiento = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Id_Categoria = table.Column<int>(type: "int", nullable: false),
                    Nombre_Emprendimiento = table.Column<string>(type: "text", nullable: true),
                    Descripcion_Emprendimiento = table.Column<string>(type: "text", nullable: true),
                    Logo = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emprendimiento", x => x.Id_Emprendimiento);
                });

            migrationBuilder.CreateTable(
                name: "Factura_Cabecera",
                columns: table => new
                {
                    Id_Cabecera = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Id_Iva = table.Column<int>(type: "int", nullable: false),
                    Fecha_Cabecera = table.Column<DateTime>(type: "datetime", nullable: false),
                    Nombre_Cliente = table.Column<string>(type: "text", nullable: true),
                    Cedula_Cliente = table.Column<string>(type: "text", nullable: true),
                    Telefono_Cliente = table.Column<string>(type: "text", nullable: true),
                    Direccion_Cliente = table.Column<string>(type: "text", nullable: true),
                    Nro_Factura = table.Column<int>(type: "int", nullable: false),
                    Subtotal = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Iva_Total = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Total = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Iva_Cero = table.Column<decimal>(type: "decimal(18, 2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Factura_Cabecera", x => x.Id_Cabecera);
                });

            migrationBuilder.CreateTable(
                name: "Iva",
                columns: table => new
                {
                    Id_Iva = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Valor_Iva = table.Column<decimal>(type: "decimal(18, 2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Iva", x => x.Id_Iva);
                });

            migrationBuilder.CreateTable(
                name: "Producto",
                columns: table => new
                {
                    Id_Producto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Id_Emprendimiento = table.Column<int>(type: "int", nullable: false),
                    Nombre_Producto = table.Column<string>(type: "text", nullable: true),
                    Precio_Fabricacion = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Descripcion = table.Column<string>(type: "text", nullable: true),
                    Foto = table.Column<string>(type: "text", nullable: true),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    Fecha_Caducidad = table.Column<DateTime>(type: "datetime", nullable: false),
                    Precio_Venta = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Iva = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Producto", x => x.Id_Producto);
                });

            migrationBuilder.CreateTable(
                name: "Producto_Tiene_Proveedor",
                columns: table => new
                {
                    Id_Proveedor = table.Column<int>(type: "int", nullable: false),
                    Id_Producto = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Proveedor",
                columns: table => new
                {
                    Id_Proveedor = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Id_Provincia = table.Column<int>(type: "int", nullable: false),
                    Nombre_Proveedor = table.Column<string>(type: "text", nullable: true),
                    Telefono = table.Column<string>(type: "text", nullable: true),
                    E_Mail_Proveedor = table.Column<string>(type: "text", nullable: true),
                    Producto = table.Column<string>(type: "text", nullable: true),
                    RUC = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proveedor", x => x.Id_Proveedor);
                });

            migrationBuilder.CreateTable(
                name: "Provincia",
                columns: table => new
                {
                    Id_Provincia = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Nombre_Provincia = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provincia", x => x.Id_Provincia);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Id_Usuario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Id_Provincia = table.Column<int>(type: "int", nullable: false),
                    Nombre_Usuario = table.Column<string>(type: "text", nullable: true),
                    Apellido_Usuario = table.Column<string>(type: "text", nullable: true),
                    Celular = table.Column<string>(type: "text", nullable: true),
                    E_Mail = table.Column<string>(type: "text", nullable: true),
                    Username = table.Column<string>(type: "text", nullable: true),
                    Contrasena = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Id_Usuario);
                });

            migrationBuilder.CreateTable(
                name: "Usuario_Tiene_Emprendimientos",
                columns: table => new
                {
                    Id_Usuario = table.Column<int>(type: "int", nullable: false),
                    Id_Emprendimiento = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categoria");

            migrationBuilder.DropTable(
                name: "Detalle_Factura");

            migrationBuilder.DropTable(
                name: "Emprendimiento");

            migrationBuilder.DropTable(
                name: "Factura_Cabecera");

            migrationBuilder.DropTable(
                name: "Iva");

            migrationBuilder.DropTable(
                name: "Producto");

            migrationBuilder.DropTable(
                name: "Producto_Tiene_Proveedor");

            migrationBuilder.DropTable(
                name: "Proveedor");

            migrationBuilder.DropTable(
                name: "Provincia");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Usuario_Tiene_Emprendimientos");
        }
    }
}
