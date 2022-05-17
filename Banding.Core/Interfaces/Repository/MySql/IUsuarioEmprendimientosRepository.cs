﻿using Banding.Core.Models.Entities.MySql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banding.Core.Interfaces.Repository.MySql
{
    public interface IUsuarioEmprendimientosRepository
    {
        public UsuarioTieneEmprendimientos GetUsuarioEmprendimientoByIdUsuario(int? IdUsuario);
        public UsuarioTieneEmprendimientos GetUsuarioEmprendimientoByIdEmprendimiento(int? IdEmprendimiento);
        public List<UsuarioTieneEmprendimientos> GetUsuarioEmprendimientos();
    }
}
