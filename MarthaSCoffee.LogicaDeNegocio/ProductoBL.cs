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
        public decimal ComprarProducto(Producto producto, int cantidad)
        {
            // Validamos que el producto no sea nulo y tenga un precio válido
            if (producto == null || producto.CostoxUnidad <= 0)
                throw new ArgumentException("El producto no es válido");

            // Validamos que la cantidad sea mayor que cero
            if (cantidad <= 0)
                throw new ArgumentException("La cantidad debe ser mayor que cero");

            // Calculamos el subtotal sin IVA
            decimal subtotal = (decimal)(producto.CostoxUnidad * cantidad);
            // Calculamos el IVA usando un valor fijo del 21%
            decimal iva = subtotal * 0.21m;
            // Calculamos el total con IVA
            decimal total = subtotal + iva;
            // Retornamos el total
            return total;
        }
    }
}
