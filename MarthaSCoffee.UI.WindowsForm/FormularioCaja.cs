using MarthaSCoffee.AccesoADatos;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MarthaSCoffee.UI.WindowsForm
{
    public partial class frmCaja : Form
    {
        public frmCaja()
        {
            InitializeComponent();
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
        private void frmCaja_Load(object sender, EventArgs e)
        {
            cargarComboBox();
           

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
                    int FKEmpleado;
                    int.TryParse(cmbEmpleados.SelectedValue.ToString(), out FKEmpleado);
                    xpedido.FKIdEmpleado = FKEmpleado;

                    //combo box productos
                    int FKProducto;
                    int.TryParse(cmbProduc.SelectedValue.ToString(), out FKProducto);
                    xpedido.FkIdProducto = FKProducto;
                    //PAGO

                    TipoPago pago = new TipoPago();
                    if (pago.ShowDialog() == DialogResult.OK)
                    {
                        ;
                    }
                    int resultado = PedidosBLL.Insertar(xpedido);


                  
                }
            }
        
        }
    }
}
