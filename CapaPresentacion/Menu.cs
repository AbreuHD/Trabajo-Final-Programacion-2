using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NetFramework.Layers.WinApp;
using CapaPresentacion;
using CapaPresentacion.Pantalla_Principales;
using NetFramework.Layers.WinApp.Pantallas_Secundarias;

namespace NetFramework.Layers.WinApp
{
    public partial class Menu : Form
    {
        String usuario;
        public Menu(String usuario)
        {
            this.usuario = usuario;
            InitializeComponent();
        }

        private void gruposEntidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CPGruposEntidades grupoEntidades = new CPGruposEntidades();
            grupoEntidades.MdiParent = this;
            grupoEntidades.Show();

        }

        private void tiposEntidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CPTipoEntidad tipoEntidades = new CPTipoEntidad();
            tipoEntidades.MdiParent = this;
            tipoEntidades.Show();
        }

        private void entidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CPEntidades entidades = new CPEntidades();
            entidades.MdiParent = this;
            entidades.Show();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Visible = true;
            Dispose();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            UserNameMenu.Text = "| Usuario : " + usuario ;
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutUs acerca = new AboutUs();
            acerca.MdiParent = this;
            acerca.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Hora.Text = "| Fecha y hora : " + DateTime.Now.ToString() + " |";
        }
    }
}
