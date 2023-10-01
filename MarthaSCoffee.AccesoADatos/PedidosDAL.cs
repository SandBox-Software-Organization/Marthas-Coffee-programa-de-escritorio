using MarthaSCoffee.EntidadesDeNegocios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarthaSCoffee.AccesoADatos
{
    public class PedidosDAL
    {
        public static int Insertar(Pedido pedido)
        {
            string consulta = string.Format("INSERT INTO PEDIDOS(CLIENTE, FK_IDPRODUCTO, FK_IDEMPLEADO, FK_ID_PAGO, MONTO_TOTAL) VALUES('{0}', '{1}', '{2}', '{3}', '{4}')", 
                pedido.Cliente, pedido.FkIdProducto, pedido.FKIdEmpleado, pedido.FK_IdPago, pedido.MontoTotal);
            return ComunDB.EjecutarComando(consulta);
        }

        public static List<Pedido> RellenarGRID()
        {
            string consulta = string.Format("SELECT IDPEDIDO, CLIENTE, FK_IDPRODUCTO, FK_IDEMPLEADO, FK_ID_PAGO FROM PEDIDOS ");


            IDataReader Leer = ComunDB.EjecutarComandoReader(consulta);
            List<Pedido> Pedidos = new List<Pedido>();
            while (Leer.Read())
            {
                Pedido xpedido = new Pedido();
                xpedido.IdPedido = Leer.GetInt32(0);
                xpedido.Cliente = Leer.GetString(1);
                xpedido.FkIdProducto = Leer.GetInt32(2);
                xpedido.FKIdEmpleado = Leer.GetInt32(3);
                xpedido.FK_IdPago = Leer.GetInt32(4);
                xpedido.MontoTotal = (float)Leer.GetDouble(5);
                Pedidos.Add(xpedido);
            }
            return Pedidos;
        }


    }
}
