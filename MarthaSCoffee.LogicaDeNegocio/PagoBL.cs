using MarthaSCoffee.AccesoADatos;
using MarthaSCoffee.EntidadesDeNegocios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarthaSCoffee.LogicaDeNegocio
{
    public class PagoBL
    {
     
               
        public static List<Pago> ComboPago()
        {
            return PagoDAL.ComboPago();
        }
    }
}
