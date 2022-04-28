using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NetFramework.Layers.CapaDatos;
namespace NetFramework.Layers.WinApp
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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            CNLogin objLogin = new CNLogin();
            if(objLogin.Verificar(tBUsuario.Text, tBPassword.Text).Rows.Count == 0)
            {
                MessageBox.Show("El usuario o contraseña estan erroneos");
            }
            else { 
                //MessageBox.Show("Login Exitoso");
                Menu menu = new Menu(tBUsuario.Text);
                menu.Show();
                Dispose();
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
