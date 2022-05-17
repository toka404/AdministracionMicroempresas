﻿using Banding.Core.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banding.Core.Interfaces.Service
{
    public interface IFacturacionService
    {
        public List<FacturaViewModel> GetFacturasByEmprendimiento(int idEmprendimiento);
        public List<FacturaViewModel> GetFacturasByEmprendimientoDates(int idEmprendimiento, DateTime fechaInicio, DateTime fechaFin);    }
}
