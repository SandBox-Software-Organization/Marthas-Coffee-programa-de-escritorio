using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarthaSCoffee.EntidadesDeNegocios
{
    public class Pedido
    {
        public int IdPedido { get; set; }
        public string Cliente { get; set; }

        public int FkIdProducto { get; set; }
        public int FKIdEmpleado { get; set; }
        public int FK_IdPago { get; set; }

        public float MontoTotal { get; set; }
    }
}
