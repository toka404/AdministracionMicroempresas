using Banding.Core.Models.Entities.MySql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banding.Core.Interfaces.Repository.MySql
{
    public interface IFacturaCabeceraRepository
    {
        public List<Factura_Cabecera> GetFacturaCabeceras();
        public Factura_Cabecera GetFacturaCabeceraById(int? id);
        public void CreateFacturaCabecera(Factura_Cabecera facturaCabecera);
        public void UpdateFacturaCabecera(Factura_Cabecera facturaCabecera);
        public void DeleteFacturaCabecera(Factura_Cabecera facturaCabecera);
        public bool FacturaCabeceraExists(int id);
    }
}
