using MarthaSCoffee.EntidadesDeNegocios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarthaSCoffee.AccesoADatos
{
    public class EmpleadosDAL
    {
        public static int Insertar(Empleados _EMPLEADO)
        {
            string consulta = string.Format("INSERT INTO EMPLEADOS(NOMBRE, FK_ID_AREA) VALUES('{0}', '{1}')", _EMPLEADO.Nombre, _EMPLEADO.Area);
            return ComunDB.EjecutarComando(consulta);
        }
        public static List<Empleados> RellenarGRID()
        {
            string consulta = string.Format("SELECT IDEMPLEADO, NOMBRE, FK_ID_AREA FROM EMPLEADOS ");


            IDataReader Leer = ComunDB.EjecutarComandoReader(consulta);
            List<Empleados> ListadoEmpleados = new List<Empleados>();
            while (Leer.Read())
            {
                Empleados xempleado = new Empleados();
                xempleado.IDEmpleado = Leer.GetInt32(0);
                xempleado.Nombre = Leer.GetString(1);
                xempleado.Area = Leer.GetInt32(2);
                ListadoEmpleados.Add(xempleado);
            }
            return ListadoEmpleados;
        }
        public static List<Empleados> empleados()
        {
            string consulta = string.Format("SELECT IDEMPLEADO, NOMBRE, FK_ID_AREA FROM EMPLEADOS ");


            IDataReader Leer = ComunDB.EjecutarComandoReader(consulta);
            List<Empleados> ListadoEmpleados = new List<Empleados>();
            while (Leer.Read())
            {
                Empleados xempleado = new Empleados();
                xempleado.IDEmpleado = Leer.GetInt32(0);
                xempleado.Nombre = Leer.GetString(1);
                xempleado.Area = Leer.GetInt32(2);
                ListadoEmpleados.Add(xempleado);
            }
            return ListadoEmpleados;
        }
        public static List<Areas> ComboXAreas()
        {
            string consulta = string.Format("SELECT IDAREA, NOMBRE_AREA FROM AREAS ");


            IDataReader Leer = ComunDB.EjecutarComandoReader(consulta);
            List<Areas> ListadoAreas = new List<Areas>();
            while (Leer.Read())
            {
                Areas xarea = new Areas();
                xarea.Id_Area = Leer.GetInt32(0);
                xarea.Nombre_Area = Leer.GetString(1);
                ListadoAreas.Add(xarea);
            }
            return ListadoAreas;
        }
    }
}
