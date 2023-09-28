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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        public string x = ""; // almacena los permisos de los usuarios
        public string xclave;
        public string usuario;
        public void cargar()
        {
            comboBox1.DataSource = UsuariosBL.ComboUsuarios(); comboBox1.DisplayMember = "TIPO_USUARIO";
            comboBox1.ValueMember = "IDUSUARIO";
        }
        private void Login_Load(object sender, EventArgs e)
        {
            cargar();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cargar();
            while (Leer.Read())
            {
                usuario = Convert.ToString(Leer["TIPO_USUARIO"]);
                xclave = Convert.ToString(Leer["CONTRASEÑA"]);
                x = Convert.ToString(Leer["permiso"]);
            }

        }
    }
}
