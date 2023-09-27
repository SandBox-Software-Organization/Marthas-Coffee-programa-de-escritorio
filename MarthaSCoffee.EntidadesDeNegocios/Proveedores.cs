using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarthaSCoffee.EntidadesDeNegocios
{
    public class Proveedores
    {
        public int ID_Proveedores { get; set; }
        public string Nombre_Proveedor { get; set; }
        public int FK_ID_Productos { get; set; }
    }
}
