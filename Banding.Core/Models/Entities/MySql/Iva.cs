using System;
using System.Collections.Generic;

#nullable disable

namespace Banding.Core.Models.Entities.MySql
{
    public partial class Iva
    {
        public Iva()
        {
            FacturaCabeceras = new HashSet<FacturaCabecera>();
        }

        public int IdIva { get; set; }
        public int? ValorIva { get; set; }

        public virtual ICollection<FacturaCabecera> FacturaCabeceras { get; set; }
    }
}
