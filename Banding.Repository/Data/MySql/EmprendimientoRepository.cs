using Banding.Core.Interfaces.Repository.MySql;
using Banding.Core.Models.Entities.MySql;
using Banding.Repository.MySql;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banding.Repository.Data.MySql
{
    public class EmprendimientoRepository : IEmprendimientoRepository
    {
        private readonly MyDbContext _context;
        public EmprendimientoRepository(MyDbContext context)
        {
            _context = context;
        }

        public void CreateEmprendimiento(Emprendimiento emprendimiento)
        {
            _context.Add(emprendimiento);
            _context.SaveChanges();
        }

        public void DeleteEmprendimiento(Emprendimiento emprendimiento)
        {
            emprendimiento.Anulado = "1";
            _context.Update(emprendimiento);
            _context.SaveChanges();
        }

        public bool EmprendimientoExists(int id)
        {
            return _context.Emprendimiento.Any(e => e.IdEmprendimiento == id);
        }

        public Emprendimiento GetEmprendimientoById(int? id)
        {
            return _context.Emprendimiento.Include(e=>e.IdCategoriaNavigation).FirstOrDefault(e => e.IdEmprendimiento == id);
        }

        public List<Emprendimiento> GetEmprendimientos()
        {
            return _context.Emprendimiento.Include(e=>e.IdCategoriaNavigation).Where(e=>e.Anulado.Equals("0")).ToList();
        }

        public void UpdateEmprendimiento(Emprendimiento emprendimiento)
        {
            _context.Update(emprendimiento);
            _context.SaveChanges();
        }
    }
}
