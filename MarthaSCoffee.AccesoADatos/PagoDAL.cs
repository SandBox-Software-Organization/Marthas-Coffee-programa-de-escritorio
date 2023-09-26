using MarthaSCoffee.EntidadesDeNegocios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarthaSCoffee.AccesoADatos
{
    public class PagoDAL
    {
        public static int Insertar(Pago PAGO)
        {
            string consulta = string.Format("INSERT INTO PAGO(TIPO_PAGO, MONTO_TOTAL) VALUES('{0}')", PAGO.TipoPago, PAGO.MontoTotal);
            return ComunDB.EjecutarComando(consulta);
        }


        public static List<Pago> ComboPago()
        {
            string consulta = string.Format("SELECT IDPAGO, TIPO_PAGO FROM PAGO ");


            IDataReader Leer = ComunDB.EjecutarComandoReader(consulta);
            List<Pago> ListadoPago = new List<Pago>();
            while (Leer.Read())
            {
                Pago xpago = new Pago();
                xpago.IdPago = Leer.GetInt32(0);
                xpago.TipoPago = Leer.GetString(1);
                ListadoPago.Add(xpago);
            }
            return ListadoPago;
        }
    }
}
