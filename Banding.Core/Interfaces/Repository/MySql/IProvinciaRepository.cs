using Banding.Core.Models.Entities.MySql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banding.Core.Interfaces.Repository.MySql
{
    public interface IProvinciaRepository
    {
        public List<Provincia> GetProvincias();
        public Provincia GetProvinciaById(int? id);
        public void CreateProvincia(Provincia provincia);
        public void UpdateProvincia(Provincia provincia);
        public void DeleteProvincia(Provincia provincia);
        public bool ProvinciaExists(int id);
    }
}
