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
        private ProductoBL gestorProductos = new ProductoBL();
        public frmCaja()
        {
            InitializeComponent();
        }

        public void Limpiar()
        {

            lblCantidad.Text = string.Empty;
            lblMontoTotal.Text = string.Empty;
            txtNomCliente.Text = string.Empty;
            cmbEmpleados.SelectedItem = null;
            combxTipoOrden.SelectedItem = null;
            comboPago.SelectedItem = null;
            txtCantidad.Text = string.Empty;
            

        }
        public void cargarComboBox()
        {
           

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
            

            // Cargamos los productos desde la capa de negocio al inicio del formulario
            dgvProductos.DataSource = ProductoBL.ComboProducto();
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
                    // Obtenemos el producto seleccionado en el dgvProductos
                    Producto producto = (Producto)dgvProductos.CurrentRow.DataBoundItem;
                    // Obtenemos la cantidad ingresada por el usuario
                    int cantidad = int.Parse(txtCantidad.Text);


                    // Compramos el producto usando la capa de negocio y obtenemos el total
                    decimal total = gestorProductos.ComprarProducto(producto, cantidad);


                    // Mostramos el total en un mensaje
                    MessageBox.Show("El total de la compra es: " + total.ToString("C"));

                    
                    //combo box empleado
                    xpedido.FKIdEmpleado = Convert.ToInt32(cmbEmpleados.SelectedIndex) + 1;

                    //PAGO

                    xpedido.FK_IdPago = Convert.ToInt32(comboPago.SelectedIndex) + 1;


                    xpedido.MontoTotal = ((float)total);


                  

                    int resultado = PedidosBLL.Insertar(xpedido);
           
                    Limpiar();
                  
                }
            }
        
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Obtenemos el producto seleccionado en el dgvProductos
            Producto producto = (Producto)dgvProductos.CurrentRow.DataBoundItem;
            // Obtenemos la cantidad ingresada por el usuario
            int cantidad = int.Parse(txtCantidad.Text);
            // Calculamos el total usando la capa de negocio
            decimal total = gestorProductos.ComprarProducto(producto, cantidad);
            // Mostramos el total en un mensaje
            MessageBox.Show("El total de su compra sería: " + total.ToString("C"));
            lblMontoTotal.Text = total.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnventas_Click(object sender, EventArgs e)
        {
            Pedidos xxx = new Pedidos();
            if (xxx.ShowDialog() == DialogResult.OK)
            {
                ;
            }
        }
    }
}
