using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Banding.Core.Models.Entities.MySql;

namespace Banding.Repository.DataBaseContext
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {

        }
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Detalle_Factura> Detalle_Factura { get; set; }
        public DbSet<Emprendimiento> Emprendimiento { get; set; }
        public DbSet<Factura_Cabecera> Factura_Cabecera { get; set; }
        public DbSet<Iva> Iva { get; set; }
        public DbSet<Producto> Producto { get; set; }
        public DbSet<Producto_Tiene_Proveedor> Producto_Tiene_Proveedor { get; set; }
        public DbSet<Proveedor> Proveedor { get; set; }
        public DbSet<Provincia> Provincia { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<Usuario_Tiene_Emprendimientos> Usuario_Tiene_Emprendimientos { get; set; }
    }
}
