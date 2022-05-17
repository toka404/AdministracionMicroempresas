using Banding.Core.Interfaces.Repository.MySql;
using Banding.Core.Models.Entities.MySql;
using Banding.Repository.MySql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banding.Repository.Data.MySql
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly MyDbContext _context;
        public CategoriaRepository(MyDbContext context)
        {
            _context = context;
        }

        public bool CategoriaExists(int id)
        {
            return _context.Categoria.Any(c => c.IdCategoria == id);
        }

        public void CreateCategoria(Categoria categoria)
        {
            _context.Add(categoria);
            _context.SaveChanges();
        }

        public void DeleteCategoria(Categoria categoria)
        {
            _context.Remove(categoria);
            _context.SaveChanges();
        }

        public Categoria GetCategoriaById(int? id)
        {
            return _context.Categoria.FirstOrDefault(c => c.IdCategoria == id);
        }

        public List<Categoria> GetCategorias()
        {
            return _context.Categoria.ToList();
        }

        public void UpdateCategoria(Categoria categoria)
        {
            _context.Update(categoria);
            _context.SaveChanges();
        }
    }
}

