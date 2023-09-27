using MarthaSCoffee.AccesoADatos;
using MarthaSCoffee.EntidadesDeNegocios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarthaSCoffee.LogicaDeNegocio
{
    public class ProveedoresBL
    {
        public static int Insertar(Proveedores proveedores)
        {
            return ProveedoresDAL.Insertar(proveedores);
        }

        public static List<Proveedores> RellenarGRID()
        {
            return ProveedoresDAL.RellenarGRID();
        }

    }
}
