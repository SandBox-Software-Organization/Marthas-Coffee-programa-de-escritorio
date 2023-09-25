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
    public partial class FormAreas : Form
    {
        public FormAreas()
        {
            InitializeComponent();
        }
        // Declaramos una variable publica para pasar el valor del grid
        public string Xvalor { get; set; }
        private void FormAreas_Load(object sender, EventArgs e)
        {
            // El evento Load del formulario
            //llamamos el método de la clase EstudianteBL
            List<Areas> resultado = AreasBL.RellenarGRID();
            //Rellenamos el grid
            GridAreas.DataSource = resultado;
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            // Código al botón Aceptar
            Xvalor = (GridAreas.CurrentCell.Value.ToString());
            DialogResult = DialogResult.OK; //cierra el formulario
            this.Close();
        }
    }
}
