using Banding.Core.Models.Entities.MySql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banding.Core.Interfaces.Repository.MySql
{
    public interface IIvaRepository
    {
        public List<Iva> GetIvas();
        public Iva GetIvaById(int? id);
        public void CreateIva(Iva iva);
        public void UpdateIva(Iva iva);
        public void DeleteIva(Iva iva);
        public bool IvaExists(int id);

    }
}
