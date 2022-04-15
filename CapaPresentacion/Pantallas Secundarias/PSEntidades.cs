using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion.Pantallas_Secundarias
{
    public partial class PSEntidades : Form
    {
        String tipo;
        public PSEntidades(String tipo)
        {
            this.tipo = tipo;
            InitializeComponent();
        }

        private void PSEntidades_Load(object sender, EventArgs e)
        {
            labelEntidades.Text = tipo;

        }


    }
}
