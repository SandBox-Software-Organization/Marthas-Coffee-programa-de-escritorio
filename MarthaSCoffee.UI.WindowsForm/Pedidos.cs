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
    public partial class Pedidos : Form
    {
        public Pedidos()
        {
            InitializeComponent();
        }

        public string pedidos { get; set; }
        private void button1_Click(object sender, EventArgs e)
        {
            pedidos = (dgvPedidos.CurrentCell.Value.ToString());
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void ConfirmacionCompra_Load(object sender, EventArgs e)
        {
            List<Pedido> resultado = PedidosBLL.RellenarGRID();
            //Rellenamos el grid
            dgvPedidos.DataSource = resultado;
        }
    }
}
