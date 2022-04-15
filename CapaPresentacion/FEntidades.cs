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

namespace CapaPresentacion
{
    public partial class FEntidades : Form
    {

        public FEntidades()
        {
            InitializeComponent();

        }


        private void MostrarEntidades()
        {
            CNEntidad objEntidad = new CNEntidad();
            dataGridView1.DataSource = objEntidad.MostrarEntidades();

        }

        private void FEntidades_Load(object sender, EventArgs e)
        {
            MostrarEntidades();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e){        }
    }
}
