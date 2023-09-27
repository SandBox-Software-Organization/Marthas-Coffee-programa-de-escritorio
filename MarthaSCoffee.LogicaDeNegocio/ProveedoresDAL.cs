using MarthaSCoffee.AccesoADatos;
using MarthaSCoffee.EntidadesDeNegocios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarthaSCoffee.LogicaDeNegocio
{
    public class ProveedoresDAL
    {
        public static int Insertar(Proveedores proveedores)
        {
            string consulta = string.Format("INSERT INTO PROVEEDORES(NOMBRE_PROVEEDOR, FK_ID_PRODUCTO) VALUES('{0}','{1}')", proveedores.Nombre_Proveedor, proveedores.FK_ID_Productos);
            return ComunDB.EjecutarComando(consulta);
        }
        public static List<Proveedores> RellenarGRID()
        {
            string consulta = string.Format("SELECT IDPROVEEDOR, NOMBRE_PROVEEDOR, FK_ID_PRODUCTO FROM PROVEEDORES ");


            IDataReader Leer = ComunDB.EjecutarComandoReader(consulta);
            List<Proveedores> ListadoProveedores = new List<Proveedores>();
            while (Leer.Read())
            {
                Proveedores xproveedores = new Proveedores();
                xproveedores.ID_Proveedores = Leer.GetInt32(0);
                xproveedores.Nombre_Proveedor = Leer.GetString(1);
                xproveedores.FK_ID_Productos = Leer.GetInt32(2);
                ListadoProveedores.Add(xproveedores);
            }
            return ListadoProveedores;
        }

        public static List<Proveedores> ComboProducto()
        {
            string consulta = string.Format("SELECT IDPROVEEDOR, NOMBRE_PROVEEDOR, FK_ID_PRODUCTO FROM PROVEEDORES ");


            IDataReader Leer = ComunDB.EjecutarComandoReader(consulta);
            List<Proveedores> ListadoProveedores = new List<Proveedores>();
            while (Leer.Read())
            {
                Proveedores xproveedores = new Proveedores();
                xproveedores.ID_Proveedores = Leer.GetInt32(0);
                xproveedores.Nombre_Proveedor = Leer.GetString(1);
                xproveedores.FK_ID_Productos = Leer.GetInt32(2);
                ListadoProveedores.Add(xproveedores);
            }
            return ListadoProveedores;
        }
    }
}

