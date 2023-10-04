using MarthaSCoffee.AccesoADatos;
using MarthaSCoffee.EntidadesDeNegocios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarthaSCoffee.LogicaDeNegocio
{
    public class EmpleadosBL
    {
        public static int Insertar(Empleados empleados)
        {
            return EmpleadosDAL.Insertar(empleados);
        }

        public static List<Empleados> RellenarGRID()
        {
            return EmpleadosDAL.RellenarGRID();
        }
        public static List<Empleados> empleados()
        {
            return EmpleadosDAL.empleados();
        }
        public static List<Areas> Areas()
        {
            return EmpleadosDAL.ComboXAreas();
        }
    }
}
