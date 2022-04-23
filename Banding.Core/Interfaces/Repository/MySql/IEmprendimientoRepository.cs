using Banding.Core.Models.Entities.MySql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banding.Core.Interfaces.Repository.MySql
{
    public interface IEmprendimientoRepository
    {
        public List<Emprendimiento> GetEmprendimientos();
        public Emprendimiento GetEmprendimientoById(int? id);
        public void CreateEmprendimiento(Emprendimiento emprendimiento);
        public void UpdateEmprendimiento(Emprendimiento emprendimiento);
        public void DeleteEmprendimiento(Emprendimiento emprendimiento);
        public bool EmprendimientoExists(int id);
    }
}
