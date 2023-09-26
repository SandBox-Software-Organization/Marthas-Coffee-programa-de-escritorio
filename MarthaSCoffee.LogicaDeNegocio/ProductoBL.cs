using MarthaSCoffee.AccesoADatos;
using MarthaSCoffee.EntidadesDeNegocios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarthaSCoffee.LogicaDeNegocio
{
    public class ProductoBL
    {
        public static int Insertar(Producto producto)
        {
            return ProductoDAL.Insertar(producto);
        }

        public static List<Producto> RellenarGRID()
        {
            return ProductoDAL.RellenarGRID();
        }

        public static List<Producto> ComboProducto()
        {
            return ProductoDAL.ComboProducto();
        }
    }
}
