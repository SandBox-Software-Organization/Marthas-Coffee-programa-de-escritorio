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
    public partial class frmCaja : Form
    {
        public frmCaja()
        {
            InitializeComponent();
        }

        public void Limpiar()
        {
            lblNumO.Text = string.Empty;
            lblMontoTotal.Text = string.Empty;
            txtNomCliente.Text = string.Empty;
            numericUpDown1.Text = string.Empty;
        }
        public void cargarComboBox()
        {
            cmbProduc.DataSource = ProductoBL.ComboProducto();
            cmbProduc.DisplayMember = "NOMBRE_PRODUCTO";
            cmbProduc.ValueMember = "IDPRODUCTO";

            cmbEmpleados.DataSource = EmpleadosBL.empleados();
            cmbEmpleados.DisplayMember = "NOMBRE";
            cmbEmpleados.ValueMember = "IDEMPLEADO";


         
        }
        public void cargarComboBoxPago()
        {
 
            comboPago.DataSource = PagoBL.ComboPago();
            comboPago.DisplayMember = "TIPO_PAGO";
            comboPago.ValueMember = "IDPAGO";

        }
        private void frmCaja_Load(object sender, EventArgs e)
        {
            cargarComboBox();
            cargarComboBoxPago();
        }

        private void Realizar_Click(object sender, EventArgs e)
        {

            if (txtNomCliente.Text.Trim() == "")
            {
                MessageBox.Show("Complete los Campos Obligatorios", "Faltan Datos",

                MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                if (MessageBox.Show("Seguro Desea Guardar Los Datos.", "Registro de Pedido", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {

                    Pedido xpedido = new Pedido();

                    xpedido.Cliente = txtNomCliente.Text.Trim().ToUpper();

                    //combo box empleado
                    xpedido.FKIdEmpleado = Convert.ToInt32(cmbEmpleados.SelectedIndex) + 1;

                    //combo box productos
                    xpedido.FkIdProducto = Convert.ToInt32(cmbProduc.SelectedIndex) + 1;

                    //PAGO

                    xpedido.FK_IdPago = Convert.ToInt32(comboPago.SelectedIndex) + 1;
                   

                    float tipopago = (float)Convert.ToDouble(lblMontoTotal.Text);
                    xpedido.MontoTotal = (float)tipopago;

                    
                   // TipoPago pago = new TipoPago();
                    //if (pago.ShowDialog() == DialogResult.OK)
                    //{
                      //  ;
                    //}                    int resultado = PedidosBLL.Insertar(xpedido);

                    Limpiar();
                  
                }
            }
        
        }

       
    }
}
