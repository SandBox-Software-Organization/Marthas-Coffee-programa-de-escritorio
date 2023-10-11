using MarthaSCoffee.AccesoADatos;
using MarthaSCoffee.EntidadesDeNegocios;

using MarthaSCoffee.LogicaDeNegocio;
using System;
using System.Diagnostics.Eventing.Reader;
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
    
            if (textBox2.Text != "Nombre de usuario")
            {
                if (textBox1.Text != "Password")
                {
                    UsuariosBL user = new UsuariosBL();
                    var validlogin = user.LOGINUSER(textBox2.Text, textBox1.Text);
                    if (validlogin == true)
                    {
                        Administracion mainmenu = new Administracion();
                        mainmenu.Show();
                        mainmenu.FormClosed += logout;
                        this.Hide();
                    }
                    
                    else
                    {
                        msgerror("es incorrecto el usuario o la contra, por favor ingrese la informacion de nuevo");
                        textBox2.Clear();
                        textBox1.Focus();
                    }
                }
                else msgerror("please enter password");
           
            }
            else msgerror("please enter username");
          
        }
        private void msgerror(string msg)
        {
            label4.Text = " " + msg;
            label4.Visible = true;

        }
        private void logout(object sender,FormClosedEventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            label4.Visible = false;
            this.Show();
            textBox2.Focus();
        }
    }
}