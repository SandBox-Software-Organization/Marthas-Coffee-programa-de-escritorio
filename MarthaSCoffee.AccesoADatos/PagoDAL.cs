﻿using MarthaSCoffee.EntidadesDeNegocios;
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
       

        public static List<Pago> ComboPago()
        {
            string consulta = string.Format("SELECT IDPAGO, TIPO_PAGO FROM PAGO ");


            IDataReader Leer = ComunDB.EjecutarComandoReader(consulta);
            List<Pago> formPago = new List<Pago>();
            while (Leer.Read())
            {
                Pago xpago = new Pago
                {
                    IdPago = Leer.GetInt32(0),
                    TipoPago = Leer.GetString(1)
                };
                formPago.Add(xpago);
            }
            return formPago;
        }
    }
}
