using MarthaSCoffee.AccesoADatos;
using MarthaSCoffee.EntidadesDeNegocios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarthaSCoffee.LogicaDeNegocio
{
    public class PedidosBLL
    {
        public static int Insertar(Pedido pedidos)
        {
            return PedidosDAL.Insertar(pedidos);
        }

        public static List<Pedido> RellenarGRID()
        {
            return PedidosDAL.RellenarGRID();
        }


    }
}
