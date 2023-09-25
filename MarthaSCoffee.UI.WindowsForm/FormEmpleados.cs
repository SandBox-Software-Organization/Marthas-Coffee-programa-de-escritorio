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
    public partial class FormEmpleados : Form
    {
        public FormEmpleados()
        {
            InitializeComponent();
        }
        // Declaramos una variable publica para pasar el valor del grid
        public string Avalor { get; set; }
        private void FormEmpleados_Load(object sender, EventArgs e)
        {

            // El evento Load del formulario
            //llamamos el método de la clase EstudianteBL
            List<Empleados> resultado = EmpleadosBL.empleados();
            //Rellenamos el grid
            GridEmpleados.DataSource = resultado;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            // Código al botón Aceptar
            Avalor = (GridEmpleados.CurrentCell.Value.ToString());
            DialogResult = DialogResult.OK; //cierra el formulario
            this.Close();
        }
    }
}
