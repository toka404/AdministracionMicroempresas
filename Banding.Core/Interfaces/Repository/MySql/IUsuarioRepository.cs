﻿using Banding.Core.Models.Entities.MySql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banding.Core.Interfaces.Repository.MySql
{
    public interface IUsuarioRepository
    {
        public Usuario GetUserByEmailUsername(string param);
        public List<Usuario> GetUsuarios();
        public Usuario GetUsuarioById(int? id);
        public void CreateUsuario(Usuario usuario);
        public void UpdateUsuario(Usuario usuario);
        public void DeleteUsuario(Usuario usuario);
        public bool UsuarioExists(int id);

    }
}
