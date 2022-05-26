using System;
using Banding.Core.Models.Entities.MySql;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Banding.Repository.MySql
{
    public partial class MyDbContext : DbContext
    {
        public MyDbContext()
        {
        }

        public MyDbContext(DbContextOptions<MyDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Categoria> Categoria { get; set; }
        public virtual DbSet<DetalleFactura> DetalleFactura { get; set; }
        public virtual DbSet<Emprendimiento> Emprendimiento { get; set; }
        public virtual DbSet<FacturaCabecera> FacturaCabecera { get; set; }
        public virtual DbSet<Iva> Iva { get; set; }
        public virtual DbSet<Producto> Producto { get; set; }
        public virtual DbSet<ProductoTieneProveedor> ProductoTieneProveedor { get; set; }
        public virtual DbSet<Proveedor> Proveedor { get; set; }
        public virtual DbSet<Provincia> Provincia { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
        public virtual DbSet<UsuarioTieneEmprendimientos> UsuarioTieneEmprendimientos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categoria>(entity =>
            {
                entity.HasKey(e => e.IdCategoria)
                    .HasName("PRIMARY");

                entity.ToTable("categoria");

                entity.Property(e => e.IdCategoria).HasColumnName("ID_CATEGORIA");

                entity.Property(e => e.NombreCategoria)
                    .HasColumnName("NOMBRE_CATEGORIA")
                    .HasMaxLength(1024);
            });

            modelBuilder.Entity<DetalleFactura>(entity =>
            {
                entity.ToTable("detalle_factura");

                entity.HasIndex(e => e.IdCabecera)
                    .HasName("FK_DETALLE__DETALLE_F_FACTURA_");

                entity.HasIndex(e => e.IdProducto)
                    .HasName("FK_DETALLE__PRODUCTO__PRODUCTO");

                entity.Property(e => e.CantidadVendida).HasColumnName("CANTIDAD_VENDIDA");

                entity.Property(e => e.IdCabecera).HasColumnName("ID_CABECERA");

                entity.Property(e => e.IdProducto).HasColumnName("ID_PRODUCTO");

                entity.Property(e => e.PrecioTotal)
                    .HasColumnName("PRECIO_TOTAL")
                    .HasColumnType("decimal(10,2)");

                entity.HasOne(d => d.IdCabeceraNavigation)
                    .WithMany(p => p.DetalleFacturas)
                    .HasForeignKey(d => d.IdCabecera)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DETALLE__DETALLE_F_FACTURA_");

                entity.HasOne(d => d.IdProductoNavigation)
                    .WithMany(p => p.DetalleFacturas)
                    .HasForeignKey(d => d.IdProducto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DETALLE__PRODUCTO__PRODUCTO");
            });

            modelBuilder.Entity<Emprendimiento>(entity =>
            {
                entity.HasKey(e => e.IdEmprendimiento)
                    .HasName("PRIMARY");

                entity.ToTable("emprendimiento");

                entity.HasIndex(e => e.IdCategoria)
                    .HasName("FK_EMPRENDI_EMPRENDIM_CATEGORI");

                entity.Property(e => e.IdEmprendimiento).HasColumnName("ID_EMPRENDIMIENTO");

                entity.Property(e => e.DescripcionEmprendimiento)
                    .HasColumnName("DESCRIPCION_EMPRENDIMIENTO")
                    .HasMaxLength(1024);

                entity.Property(e => e.IdCategoria).HasColumnName("ID_CATEGORIA");

                entity.Property(e => e.Anulado)
                    .IsRequired()
                    .HasColumnName("anulado")
                    .HasMaxLength(1)
                    .IsFixedLength()
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Logo)
                    .HasColumnName("LOGO")
                    .HasMaxLength(1024);

                entity.Property(e => e.NombreEmprendimiento)
                    .HasColumnName("NOMBRE_EMPRENDIMIENTO")
                    .HasMaxLength(1024);

                entity.HasOne(d => d.IdCategoriaNavigation)
                    .WithMany(p => p.Emprendimientos)
                    .HasForeignKey(d => d.IdCategoria)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EMPRENDI_EMPRENDIM_CATEGORI");
            });

            modelBuilder.Entity<FacturaCabecera>(entity =>
            {
                entity.HasKey(e => e.IdCabecera)
                    .HasName("PRIMARY");

                entity.ToTable("factura_cabecera");

                entity.HasIndex(e => e.IdIva)
                    .HasName("FK_FACTURA__FACTURA_C_IVA");

                entity.Property(e => e.IdCabecera).HasColumnName("ID_CABECERA");

                entity.Property(e => e.Anulado)
                    .IsRequired()
                    .HasColumnName("anulado")
                    .HasMaxLength(1)
                    .IsFixedLength()
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.CedulaCliente)
                    .IsRequired()
                    .HasColumnName("CEDULA_CLIENTE")
                    .HasMaxLength(1024);

                entity.Property(e => e.DireccionCliente)
                    .IsRequired()
                    .HasColumnName("DIRECCION_CLIENTE")
                    .HasMaxLength(1024);

                entity.Property(e => e.FechaCabecera)
                    .HasColumnName("FECHA_CABECERA")
                    .HasColumnType("date");

                entity.Property(e => e.IdIva).HasColumnName("ID_IVA");

                entity.Property(e => e.IvaCero).HasColumnName("IVA_CERO");

                entity.Property(e => e.IvaTotal)
                    .HasColumnName("IVA_TOTAL")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.NombreCliente)
                    .IsRequired()
                    .HasColumnName("NOMBRE_CLIENTE")
                    .HasMaxLength(1024);

                entity.Property(e => e.NroFactura).HasColumnName("NRO_FACTURA");

                entity.Property(e => e.Subtotal)
                    .HasColumnName("SUBTOTAL")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.TelefonoCliente)
                    .IsRequired()
                    .HasColumnName("TELEFONO_CLIENTE")
                    .HasMaxLength(1024);

                entity.Property(e => e.Total)
                    .HasColumnName("TOTAL")
                    .HasColumnType("decimal(10,2)");

                entity.HasOne(d => d.IdIvaNavigation)
                    .WithMany(p => p.FacturaCabeceras)
                    .HasForeignKey(d => d.IdIva)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FACTURA__FACTURA_C_IVA");
            });

            modelBuilder.Entity<Iva>(entity =>
            {
                entity.HasKey(e => e.IdIva)
                    .HasName("PRIMARY");

                entity.ToTable("iva");

                entity.Property(e => e.IdIva).HasColumnName("ID_IVA");

                entity.Property(e => e.ValorIva).HasColumnName("VALOR_IVA");
            });

            modelBuilder.Entity<Producto>(entity =>
            {
                entity.HasKey(e => e.IdProducto)
                    .HasName("PRIMARY");

                entity.ToTable("producto");

                entity.HasIndex(e => e.IdEmprendimiento)
                    .HasName("FK_PRODUCTO_EMPRENDIM_EMPRENDI");

                entity.Property(e => e.IdProducto).HasColumnName("ID_PRODUCTO");

                entity.Property(e => e.Descripcion)
                    .HasColumnName("DESCRIPCION")
                    .HasMaxLength(1024);

                entity.Property(e => e.EmailEnviado)
                    .IsRequired()
                    .HasColumnName("email_enviado")
                    .HasMaxLength(1)
                    .IsFixedLength()
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Anulado)
                    .IsRequired()
                    .HasColumnName("anulado")
                    .HasMaxLength(1)
                    .IsFixedLength()
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.FechaCaducidad)
                    .HasColumnName("fecha_caducidad")
                    .HasColumnType("date");

                entity.Property(e => e.Foto)
                    .HasColumnName("FOTO")
                    .HasMaxLength(1024);

                entity.Property(e => e.IdEmprendimiento).HasColumnName("ID_EMPRENDIMIENTO");

                entity.Property(e => e.Iva)
                    .IsRequired()
                    .HasColumnName("IVA")
                    .HasMaxLength(1);

                entity.Property(e => e.NombreProducto)
                    .IsRequired()
                    .HasColumnName("NOMBRE_PRODUCTO")
                    .HasMaxLength(1024);

                entity.Property(e => e.PrecioFabricacion)
                    .HasColumnName("PRECIO_FABRICACION")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.PrecioVenta)
                    .HasColumnName("PRECIO_VENTA")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.Stock).HasColumnName("STOCK");

                entity.Property(e => e.StockMinimo).HasColumnName("stock_minimo");

                entity.HasOne(d => d.IdEmprendimientoNavigation)
                    .WithMany(p => p.Productos)
                    .HasForeignKey(d => d.IdEmprendimiento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PRODUCTO_EMPRENDIM_EMPRENDI");
            });

            modelBuilder.Entity<ProductoTieneProveedor>(entity =>
            {
                entity.HasKey(e => e.IdProductoProveedor)
                    .HasName("PRIMARY");

                entity.ToTable("producto_tiene_proveedor");

                entity.HasIndex(e => e.IdProducto)
                    .HasName("FK_PRODUCTO_PRODUCTO__PRODUCTO");

                entity.HasIndex(e => e.IdProveedor)
                    .HasName("FK_PRODUCTO_PROVEEDOR_PROVEEDO");

                entity.Property(e => e.IdProductoProveedor).HasColumnName("Id_ProductoProveedor");

                entity.Property(e => e.IdProducto).HasColumnName("ID_PRODUCTO");

                entity.Property(e => e.IdProveedor).HasColumnName("ID_PROVEEDOR");

                entity.HasOne(d => d.IdProductoNavigation)
                    .WithMany(p => p.ProductoTieneProveedors)
                    .HasForeignKey(d => d.IdProducto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PRODUCTO_PRODUCTO__PRODUCTO");

                entity.HasOne(d => d.IdProveedorNavigation)
                    .WithMany(p => p.ProductoTieneProveedors)
                    .HasForeignKey(d => d.IdProveedor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PRODUCTO_PROVEEDOR_PROVEEDO");
            });

            modelBuilder.Entity<Proveedor>(entity =>
            {
                entity.HasKey(e => e.IdProveedor)
                    .HasName("PRIMARY");

                entity.ToTable("proveedor");

                entity.HasIndex(e => e.IdProvincia)
                    .HasName("FK_PROVEEDO_PROVINCIA_PROVINCI");

                entity.Property(e => e.IdProveedor).HasColumnName("ID_PROVEEDOR");

                entity.Property(e => e.EMailProveedor)
                    .HasColumnName("E_MAIL_PROVEEDOR")
                    .HasMaxLength(1024);

                entity.Property(e => e.IdProvincia).HasColumnName("ID_PROVINCIA");

                entity.Property(e => e.NombreProveedor)
                    .HasColumnName("NOMBRE_PROVEEDOR")
                    .HasMaxLength(1024);

                entity.Property(e => e.Producto)
                    .HasColumnName("PRODUCTO")
                    .HasMaxLength(1024);

                entity.Property(e => e.Ruc)
                    .HasColumnName("RUC")
                    .HasMaxLength(1024);

                entity.Property(e => e.Telefono)
                    .HasColumnName("TELEFONO")
                    .HasMaxLength(1024);

                entity.HasOne(d => d.IdProvinciaNavigation)
                    .WithMany(p => p.Proveedors)
                    .HasForeignKey(d => d.IdProvincia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PROVEEDO_PROVINCIA_PROVINCI");
            });

            modelBuilder.Entity<Provincia>(entity =>
            {
                entity.HasKey(e => e.IdProvincia)
                    .HasName("PRIMARY");

                entity.ToTable("provincia");

                entity.Property(e => e.IdProvincia).HasColumnName("ID_PROVINCIA");

                entity.Property(e => e.NombreProvincia)
                    .IsRequired()
                    .HasColumnName("NOMBRE_PROVINCIA")
                    .HasMaxLength(1024);
            });

            modelBuilder.Entity<Roles>(entity =>
            {
                entity.HasKey(e => e.IdRol)
                    .HasName("PRIMARY");

                entity.ToTable("roles");

                entity.Property(e => e.IdRol).HasColumnName("id_rol");

                entity.Property(e => e.NombreRol)
                    .IsRequired()
                    .HasColumnName("nombre_rol")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario)
                    .HasName("PRIMARY");

                entity.ToTable("usuario");

                entity.HasIndex(e => e.IdEmprendimiento)
                    .HasName("id_emprendimiento");

                entity.HasIndex(e => e.IdProvincia)
                    .HasName("FK_USUARIO_USUARIO_T_PROVINCI");

                entity.HasIndex(e => e.RolId)
                    .HasName("rol_id");

                entity.Property(e => e.IdUsuario).HasColumnName("ID_USUARIO");

                entity.Property(e => e.Anulado)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsFixedLength()
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ApellidoUsuario)
                    .HasColumnName("APELLIDO_USUARIO")
                    .HasMaxLength(1024);

                entity.Property(e => e.Celular)
                    .HasColumnName("CELULAR")
                    .HasMaxLength(1024);

                entity.Property(e => e.Contrasena)
                    .IsRequired()
                    .HasColumnName("CONTRASENA")
                    .HasMaxLength(1024);

                entity.Property(e => e.EMail)
                    .HasColumnName("E_MAIL")
                    .HasMaxLength(1024);

                entity.Property(e => e.IdEmprendimiento).HasColumnName("id_emprendimiento");

                entity.Property(e => e.IdProvincia).HasColumnName("ID_PROVINCIA");

                entity.Property(e => e.NombreUsuario)
                    .HasColumnName("NOMBRE_USUARIO")
                    .HasMaxLength(1024);

                entity.Property(e => e.RolId)
                    .HasColumnName("rol_id")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("USERNAME")
                    .HasMaxLength(1024);

                entity.HasOne(d => d.IdEmprendimientoNavigation)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.IdEmprendimiento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("usuario_ibfk_2");

                entity.HasOne(d => d.IdProvinciaNavigation)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.IdProvincia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_USUARIO_USUARIO_T_PROVINCI");

                entity.HasOne(d => d.Rol)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.RolId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("usuario_ibfk_1");
            });

            modelBuilder.Entity<UsuarioTieneEmprendimientos>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("usuario_tiene_emprendimientos");

                entity.HasIndex(e => e.IdEmprendimiento)
                    .HasName("FK_USUARIO__EMPRENDIM_EMPRENDI");

                entity.HasIndex(e => e.IdUsuario)
                    .HasName("FK_USUARIO__USUARIO_T_USUARIO");

                entity.Property(e => e.IdEmprendimiento).HasColumnName("ID_EMPRENDIMIENTO");

                entity.Property(e => e.IdUsuario).HasColumnName("ID_USUARIO");

                entity.HasOne(d => d.IdEmprendimientoNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdEmprendimiento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_USUARIO__EMPRENDIM_EMPRENDI");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_USUARIO__USUARIO_T_USUARIO");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
