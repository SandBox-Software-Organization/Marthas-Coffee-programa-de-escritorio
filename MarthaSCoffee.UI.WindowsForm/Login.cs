using MarthaSCoffee.EntidadesDeNegocios;
using MarthaSCoffee.LogicaDeNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
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

        private void Login_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "User Name" && textBox1.Text != "Password")
            {
                UsuariosBL user = new UsuariosBL();
                var validlogin = user.LOGINUSER(textBox2.Text, textBox1.Text);
                if (validlogin == true)
                {
                    Administracion Ad = new Administracion();
                    Ad.Show();
                    this.Hide();
                }
                else
                {
                    msgerror("Es incorrecto el usuario o la contraseña, por favor ingresar de nuevo");
                    textBox1.Clear();
                    textBox2.Focus();
                }

            }

        }
        private void msgerror(string msg)
        {
            label4.Text = " " + msg;
            label4.Visible = true;
        }
        private void logout (object sender, FormClosedEventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            label4.Visible = false;

        }



    }
  
    
}
