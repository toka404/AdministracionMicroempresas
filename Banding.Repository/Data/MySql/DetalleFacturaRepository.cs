using Banding.Core.Interfaces.Repository.MySql;
using Banding.Core.Models.Entities.MySql;
using Banding.Core.Models.ViewModels;
using Banding.Repository.MySql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banding.Repository.Data.MySql
{
    public class DetalleFacturaRepository : IDetalleFacturaRepository
    {
        private readonly MyDbContext _context;
        public DetalleFacturaRepository(MyDbContext context)
        {
            _context = context;
        }

        public void CreateDetalleFactura(DetalleFactura detalleFactura)
        {
            _context.Add(detalleFactura);
            _context.SaveChanges();
        }

        public void DeleteDetalleFactura(DetalleFactura detalleFactura)
        {
            _context.Remove(detalleFactura);
            _context.SaveChanges();
        }
        public List<ChartProductoViewModel> GetDetallesGroupByProducto(int idEmprendimiento)
        {
            var listaProductos = new List<ChartProductoViewModel>();
            var detalleFacturaJoinProducto = _context.DetalleFactura.Join(
                   _context.Producto,
                   c => c.IdProducto,
                   x => x.IdProducto,
                   (detalles, producto) =>
                       new
                       {
                           detalles,
                           producto
                       }).GroupBy(t => t.producto.NombreProducto);
            var lenght = detalleFacturaJoinProducto.Count();
            if (lenght > 4)
            {
                listaProductos = detalleFacturaJoinProducto.Select(movieGroup => new ChartProductoViewModel
                 {
                     Producto = movieGroup.Key,
                     Cantidad = movieGroup.Sum(t => t.detalles.CantidadVendida),
                     Emprendimiento = movieGroup.Max(t => t.producto.IdEmprendimiento),
                     Cabecera = movieGroup.Max(t => t.detalles.IdCabecera),
                     PrecioTotal = movieGroup.Sum(t => t.detalles.PrecioTotal)
                 }).Where(t => t.Emprendimiento == idEmprendimiento).OrderBy(t => t.Cantidad).
                 Take(lenght-4).ToList();
            }
            return listaProductos;
        }
        public List<ChartProductoViewModel> GetDetallesGroupByDescendingProducto(int idEmprendimiento)
        {
            return _context.DetalleFactura.Join(
                   _context.Producto,
                   c => c.IdProducto,
                   x => x.IdProducto,
                   (detalles, producto) =>
                       new
                       {
                           detalles,
                           producto
                       }).GroupBy(t => t.producto.NombreProducto)
                    .Select(movieGroup => new ChartProductoViewModel
                    {
                        Producto = movieGroup.Key,
                        Cantidad = movieGroup.Sum(t => t.detalles.CantidadVendida),
                        Emprendimiento = movieGroup.Max(t => t.producto.IdEmprendimiento),
                        Cabecera = movieGroup.Max(t => t.detalles.IdCabecera),
                        PrecioTotal = movieGroup.Sum(t => t.detalles.PrecioTotal)
                    }).Where(t => t.Emprendimiento == idEmprendimiento).OrderByDescending(t => t.Cantidad).ToList();
        }

        public List<DetalleFactura> GetDetalleFacturasByIdCabecera(int? idCabecera)
        {
            return _context.DetalleFactura.Where(d => d.IdCabecera == idCabecera).Distinct().ToList();
        }

        public List<DetalleFactura> GetDetalleFacturas()
        {
            return _context.DetalleFactura.ToList();
        }

        public void UpdateDetalleFactura(DetalleFactura detalleFactura)
        {
            _context.Update(detalleFactura);
            _context.SaveChanges();
        }
    }
}
