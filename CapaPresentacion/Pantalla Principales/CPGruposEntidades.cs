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

namespace CapaPresentacion.Pantalla_Principales
{
    public partial class CPGruposEntidades : Form
    {

        public CPGruposEntidades()
        {
            InitializeComponent();
        }

        private void CPGruposEntidades_Load(object sender, EventArgs e)
        {
            obtenerTabla();
        }

        private void btCrear_Click(object sender, EventArgs e)
        {
            PSGrupoEntidades crear = new PSGrupoEntidades("Crear Grupo Entidades", "Crear");
            crear.Show();
        }

        public void obtenerTabla()
        {
            CNGruposEntidades objGruposEntidades = new CNGruposEntidades();
            dGVGruposEntidades.DataSource = objGruposEntidades.MostrarEntidades();
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            if (dGVGruposEntidades.SelectedRows.Count > 0)
            {
                PSGrupoEntidades editar = new PSGrupoEntidades("Editar Grupo Entidades", "Editar", dGVGruposEntidades.CurrentRow.Cells["IdGrupoEntidad"].Value.ToString());
                editar.Show();
            }
            else
            {
                MessageBox.Show("Debes selecciona una fila de la tabla");
            }

        }
        private void btEliminar_Click(object sender, EventArgs e)
        {   
            if(dGVGruposEntidades.SelectedRows.Count > 0)
            {
                CNGruposEntidades objGruposEntidades = new CNGruposEntidades();
                if (objGruposEntidades.EliminarDatos(dGVGruposEntidades.CurrentRow.Cells["IdGrupoEntidad"].Value.ToString()))
                {
                    MessageBox.Show("La eliminacion Fue Exitosa");
                    obtenerTabla();
                }
            }
            else
            {
                MessageBox.Show("Debes Selecciona una fila en la tabla.");
            }
        }
    }
}
