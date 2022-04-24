using Banding.Core.Models.Entities.MySql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banding.Core.Interfaces.Service
{
    public interface IInventarioService
    {
        public void SendEmail(List<Producto> productos, string user, string email);

    }
}
