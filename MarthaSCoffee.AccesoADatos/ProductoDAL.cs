using MarthaSCoffee.EntidadesDeNegocios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarthaSCoffee.AccesoADatos
{
    public class ProductoDAL
    {
        public static int Insertar(Producto producto)
        {
            string consulta = string.Format("INSERT INTO PRODUCTOS(NOMBRE_PRODUCTO, COSTOXUNIDAD) VALUES('{0}', '{1}')", producto.NombreProducto, producto.CostoxUnidad);
            return ComunDB.EjecutarComando(consulta);
        }
        public static List<Producto> RellenarGRID()
        {
            string consulta = string.Format("SELECT IDPRODUCTO, NOMBRE_PRODUCTO, COSTOXUNIDAD FROM PRODUCTOS ");


            IDataReader Leer = ComunDB.EjecutarComandoReader(consulta);
            List<Producto> ListadoProducto = new List<Producto>();
            while (Leer.Read())
            {
                Producto xproducto = new Producto();
                xproducto.IdProducto = Leer.GetInt32(0);
                xproducto.NombreProducto = Leer.GetString(1);
                xproducto.CostoxUnidad = (float)Leer.GetDecimal(2);
                ListadoProducto.Add(xproducto);
            }
            return ListadoProducto;
        }

        public static List<Producto> ComboProducto()
        {
            string consulta = string.Format("SELECT IDPRODUCTO, NOMBRE_PRODUCTO, COSTOXUNIDAD FROM PRODUCTOS ");


            IDataReader Leer = ComunDB.EjecutarComandoReader(consulta);
            List<Producto> ListadoProducto = new List<Producto>();
            while (Leer.Read())
            {
                Producto xproducto = new Producto();
                xproducto.IdProducto = Leer.GetInt32(0);
                xproducto.NombreProducto = Leer.GetString(1);
                xproducto.CostoxUnidad = (float)Leer.GetDecimal(2);
                ListadoProducto.Add(xproducto);
            }
            return ListadoProducto;
        }

        public decimal ComprarProducto(Producto producto, int cantidad)
        {
            // Validamos que el producto no sea nulo y tenga un precio válido luego  
            if (producto == null || producto.CostoxUnidad <= 0)
                throw new ArgumentException("El producto no es válido");

            //vlidamos que la cantidad sea mayor que cero
            if (cantidad <= 0)
                throw new ArgumentException("La cantidad debe ser mayor que cero");

           //calculamos x por la vantidad
            decimal total = (decimal)(producto.CostoxUnidad * cantidad);
            
           
            return total;
        }
    }
}
