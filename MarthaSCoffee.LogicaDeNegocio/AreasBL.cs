using MarthaSCoffee.AccesoADatos;
using MarthaSCoffee.EntidadesDeNegocios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarthaSCoffee.LogicaDeNegocio
{
    public class AreasBL
    {
        public static int Insertar(Areas areas)
        {
            return AreasDAL.Insertar(areas);
        }

        public static List<Areas> RellenarGRID()
        {
            return AreasDAL.RellenarGRID();
        }

        public static List<Areas> ComboAreas()
        {
            return AreasDAL.ComboAreas();
        }
    }
}
