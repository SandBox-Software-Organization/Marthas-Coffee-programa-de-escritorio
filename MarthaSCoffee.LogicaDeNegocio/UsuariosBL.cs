using MarthaSCoffee.AccesoADatos;
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
        public static List<EntidadesDeNegocios.UsuariosBL> ComboUsuarios()
        {
            return UsuariosDAL.ComboUsuarios();
        }
    }
}
