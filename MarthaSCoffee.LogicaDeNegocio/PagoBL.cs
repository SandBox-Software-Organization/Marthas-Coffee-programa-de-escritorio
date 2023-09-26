using MarthaSCoffee.AccesoADatos;
using MarthaSCoffee.EntidadesDeNegocios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarthaSCoffee.LogicaDeNegocio
{
    internal class PagoBL
    {
        public static int Insertar(Pago pago)
        {
            return PagoDAL.Insertar(pago);
        }
               
        public static List<Pago> ComboPago()
        {
            return PagoDAL.ComboPago();
        }
    }
}
