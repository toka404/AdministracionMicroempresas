﻿using Banding.Core.Models.Entities.MySql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banding.Core.Models.ViewModels
{
    public class FacturaViewModel
    {
        public Factura_Cabecera FacturaCabecera { get; set; }
        public List<DetalleFacturaViewModel> DetalleFactura { get; set; }
        public int Iva { get; set; }

    }
}