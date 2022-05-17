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
        public ICollection<FacturaCabecera> GetFacturaCabeceras();
        public FacturaCabecera GetFacturaCabeceraById(int? id);
        public void CreateFacturaCabecera(FacturaCabecera facturaCabecera);
        public void UpdateFacturaCabecera(FacturaCabecera facturaCabecera);
        public void DeleteFacturaCabecera(int id);
        public ICollection<DetalleFactura> GetDetallesByIdCabecera(int idCabecera);
        public bool FacturaCabeceraExists(int id);
        public ICollection<FacturaCabecera> GetFacturaCabecerasByDates(DateTime fechaInicio, DateTime fechaFin);
    }
}
