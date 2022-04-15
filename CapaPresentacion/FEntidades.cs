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
using CapaPresentacion.Pantallas_Secundarias;

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
            dGEntidades.DataSource = objEntidad.MostrarEntidades();

        }

        private void FEntidades_Load(object sender, EventArgs e)
        {
            MostrarEntidades();
        }

        private void btCrear_Click(object sender, EventArgs e)
        {
            PSEntidades crear = new PSEntidades("Crear Entidad");
            crear.Show();
        }
    }
}
