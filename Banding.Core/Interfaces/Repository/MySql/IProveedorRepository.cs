using Banding.Core.Models.Entities.MySql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banding.Core.Interfaces.Repository.MySql
{
    public interface IProveedorRepository
    {
        public List<Proveedor> GetProveedores();
        public Proveedor GetProveedorById(int? id);
        public void CreateProveedor(Proveedor proveedor);
        public void UpdateProveedor(Proveedor proveedor);
        public void DeleteProveedor(Proveedor proveedor);
        public bool ProveedorExists(int id);
    }
}
