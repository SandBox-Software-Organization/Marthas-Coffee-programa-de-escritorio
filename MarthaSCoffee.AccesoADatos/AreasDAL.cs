using MarthaSCoffee.EntidadesDeNegocios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarthaSCoffee.AccesoADatos
{
    public class AreasDAL
    {
        public static int Insertar(Areas AREA)
        {
            string consulta = string.Format("INSERT INTO AREAS(NOMBRE_AREA) VALUES('{0}')", AREA.Nombre_Area);
            return ComunDB.EjecutarComando(consulta);
        }
        public static List<Areas> RellenarGRID()
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

        public static List<Areas> ComboAreas()
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
