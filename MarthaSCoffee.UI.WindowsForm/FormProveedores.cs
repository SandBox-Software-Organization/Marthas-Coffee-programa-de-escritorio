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
    public partial class FormProveedores : Form
    {
        public FormProveedores()
        {
            InitializeComponent();
        }

        public string Gvalor { get; set; }
        private void FormProveedores_Load(object sender, EventArgs e)
        {
            List<Proveedores> resultado = ProveedoresBL.RellenarGRID();
            //Rellenamos el grid
            GridProveedores.DataSource = resultado;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Gvalor = (GridProveedores.CurrentCell.Value.ToString());
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
