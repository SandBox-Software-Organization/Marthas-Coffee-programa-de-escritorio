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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MarthaSCoffee.UI.WindowsForm
{
    public partial class Administracion : Form
    {
        public Administracion()
        {
            InitializeComponent();
        }

        public void LimpiarTextos()
        {
            //Función limpiar
            txtIDAreas.Text = string.Empty;
            txtNombreArea.Text = string.Empty;
            txtIdEmpleado.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtNombreProveedor.Text = string.Empty;
            txtNombreproducto.Text = string.Empty;
            txtCostoXunidad.Text = string.Empty;
            txtNombreproducto.Focus();
            txtNombreProveedor.Focus();
            txtNombreArea.Focus();
            txtNombre.Focus();
        }

        private void btnSaveEmpleado_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim() == "")
            {
                MessageBox.Show("Complete los Campos Obligatorios", "Faltan Datos",

                MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                if (MessageBox.Show("Seguro Desea Guardar Los Datos.", "Registro de Empleados", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {

                    Empleados empleados = new Empleados();
                    empleados.Nombre = txtNombre.Text.Trim().ToUpper();
                    //Mandamos a llamar el método INSERTAR de la capa de Negocios
                    //y le pasamos la instancia ya con datos para que se guarde

                    //Este codigoes para guardar el area del empleado.
                    int FKArea;
                    int.TryParse(cmbAreas.SelectedValue.ToString(), out FKArea);
                    empleados.Area = FKArea;
                    int resultado = EmpleadosBL.Insertar(empleados);

                    //Limpiamos los controles y enviamos el enfoque a txtNombre

                    LimpiarTextos();
                }
            }
        }

        private void btnShowEmpleados_Click(object sender, EventArgs e)
        {
            FormEmpleados xform = new FormEmpleados();
            if (xform.ShowDialog() == DialogResult.OK)
            {
                ;
            }
        }

        private void btnCancelarEM_Click(object sender, EventArgs e)
        {
            LimpiarTextos();
        }

        //------------------------------------------------------------------------
        //-------------------------------AREAS------------------------------------
        //------------------------------------------------------------------------
        private void SaveAreas_Click(object sender, EventArgs e)
        {

            if (txtNombreArea.Text.Trim() == "")
            {
                MessageBox.Show("Complete los Campos Obligatorios", "Faltan Datos",

                MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                if (MessageBox.Show("Seguro Desea Guardar Los Datos.", "Registro de Áreas", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {

                    Areas _AREA = new Areas();
                    _AREA.Nombre_Area = txtNombreArea.Text.Trim().ToUpper();
                    
                    int resultado = AreasBL.Insertar(_AREA);
       

                    LimpiarTextos();
                }
            }
        }

        private void MostrarAreas_Click(object sender, EventArgs e)
        {
            FormAreas xform = new FormAreas();
            if (xform.ShowDialog() == DialogResult.OK)
            {
                ;
            }


        }

        private void CancelarArea_Click(object sender, EventArgs e)
        {
            LimpiarTextos();
        }

        //metodo que se encargara de los comboBox
        private void cargar()
        {
            cmbAreas.DataSource = AreasBL.ComboAreas();
            cmbAreas.DisplayMember = "NOMBRE_AREA";
            cmbAreas.ValueMember = "IDAREA";
       
        }

        public void cargarproducts()
        {
            cmbProductos.DataSource = ProductoBL.ComboProducto();
            cmbProductos.DisplayMember = "NOMBRE_PRODUCTO";
            cmbProductos.ValueMember = "IDPRODUCTO";
        }
        private void Administración_Load(object sender, EventArgs e)
        {

            cargar();
            cargarproducts();

            // TODO: esta línea de código carga datos en la tabla 'bD_SISTEMA_MARTHAS_EndDataSet.AREAS' Puede moverla o quitarla según sea necesario.

        }


        //-----------------------------------------------------------------
        //-----------------------PRODUCTOS---------------------------------
        //----------------------------------------------------------------

        private void GuardarProduct_Click(object sender, EventArgs e)
        {
            if (txtNombreproducto.Text.Trim() == "" || txtCostoXunidad.Text.Trim() == "")
            {
                MessageBox.Show("Complete los Campos Obligatorios", "Faltan Datos",

                MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                if (MessageBox.Show("Seguro Desea Guardar Los Datos.", "Registro de Productos", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {

                    Producto producto = new Producto();
                    var costoXunidad = Convert.ToDouble(txtCostoXunidad.Text);
                    producto.NombreProducto = txtNombreproducto.Text.Trim().ToUpper();
                    producto.CostoxUnidad = (float)costoXunidad;
              
                    int resultado = ProductoBL.Insertar(producto);

                    LimpiarTextos();
                }
            }
        }

        private void MostrarProduct_Click(object sender, EventArgs e)
        {
            FormProductos formProductos = new FormProductos();
            if (formProductos.ShowDialog() == DialogResult.OK)
            {
                ;
            }
        }

        private void CancelarProduct_Click(object sender, EventArgs e)
        {
            LimpiarTextos();
        }



        //-----------------------------------------------------------------
        //-----------------------PROVEEDORES---------------------------------
        //------------------------------------------------------------------

        private void btnGuardarProveedor_Click(object sender, EventArgs e)
        {
            if (txtNombreProveedor.Text.Trim() == "")
            {
                MessageBox.Show("Complete los Campos Obligatorios", "Faltan Datos",

                MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                if (MessageBox.Show("Seguro Desea Guardar Los Datos.", "Registro de Proveedores", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {

                    Proveedores xproveedor = new Proveedores();

                    xproveedor.Nombre_Proveedor = txtNombreProveedor.Text.Trim().ToUpper();

                    int FKProduct;
                    int.TryParse(cmbProductos.SelectedValue.ToString(), out FKProduct);
                    xproveedor.FK_ID_Productos = FKProduct;
                    int resultado = ProveedoresBL.Insertar(xproveedor);


                    LimpiarTextos();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarTextos();
        }

        private void btnMostrarProveedores_Click(object sender, EventArgs e)
        {
            FormProveedores formProveedores = new FormProveedores();
            if (formProveedores.ShowDialog() == DialogResult.OK)
            {
                ;
            }
        }
    }
}

 