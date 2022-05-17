using Banding.Core.Models.Entities.MySql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banding.Core.Interfaces.Repository.MySql
{
    public interface ICategoriaRepository
    {
        public List<Categoria> GetCategorias();
        public Categoria GetCategoriaById(int? id);
        public void CreateCategoria(Categoria categoria);
        public void UpdateCategoria(Categoria categoria);
        public void DeleteCategoria(Categoria categoria);
        public bool CategoriaExists(int id);
    }
}
