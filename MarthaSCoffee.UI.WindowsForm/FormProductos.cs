using MarthaSCoffee.EntidadesDeNegocios;
using MarthaSCoffee.LogicaDeNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarthaSCoffee.UI.WindowsForm
{
    public partial class FormProductos : Form
    {
        public FormProductos()
        {
            InitializeComponent();
        }
        public string X { get; set; }
        private void FormProductos_Load(object sender, EventArgs e)
        {
            List<Producto> resultado = ProductoBL.RellenarGRID();
            //Rellenamos el grid
            GridProductos.DataSource = resultado;
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            // Código al botón Aceptar
            X = (GridProductos.CurrentCell.Value.ToString());
            DialogResult = DialogResult.OK; //cierra el formulario
            this.Close();
        }
    }
}
