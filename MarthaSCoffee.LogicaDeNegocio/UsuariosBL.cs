﻿using MarthaSCoffee.AccesoADatos;
using MarthaSCoffee.EntidadesDeNegocios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarthaSCoffee.LogicaDeNegocio
{
    public class UsuariosBL
    {
        UsuariosDAL usuaridal = new UsuariosDAL();
        public bool LOGINUSER(string user, string password)
        {
            return usuaridal.LOGIN(user, password);
        }
    }
}
