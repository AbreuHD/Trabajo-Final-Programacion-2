using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NetFramework.Layers.ADO.Net;

namespace CapaPresentacion.Pantalla_Principales
{
    public partial class CPTipoEntidad : Form
    {

        NetFramework.Layers.CapaDatos.CNTipoEntidad objTipoEntidad = new NetFramework.Layers.CapaDatos.CNTipoEntidad();

        public CPTipoEntidad()
        {
            InitializeComponent();
        }

        private void CDTipoEntidad_Load(object sender, EventArgs e)
        {
            MostrarTabla();
        }

        public void MostrarTabla()
        {
            NetFramework.Layers.CapaDatos.CNTipoEntidad objTipoEntidadTabla = new NetFramework.Layers.CapaDatos.CNTipoEntidad();
            dGVTipoEntidad.DataSource = objTipoEntidadTabla.MostrarTipoEntidades();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Pantallas_Secundarias.TiposEntidades.PSTiposEntidades crear = new Pantallas_Secundarias.TiposEntidades.PSTiposEntidades("Crear tipo entidades", "Crear");
            DialogResult dialogResult = crear.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                MostrarTabla();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            if(dGVTipoEntidad.SelectedRows.Count > 0)
            {
                Pantallas_Secundarias.TiposEntidades.PSTiposEntidades editar = new Pantallas_Secundarias.TiposEntidades.PSTiposEntidades(
                                                                          "Editar tipo entidades", "Editar", dGVTipoEntidad.CurrentRow.Cells["IdTipoEntidad"].Value.ToString(),
                                                                           dGVTipoEntidad.CurrentRow.Cells["Descripcion"].Value.ToString(), dGVTipoEntidad.CurrentRow.Cells["Comentario"].Value.ToString(),
                                                                           dGVTipoEntidad.CurrentRow.Cells["SStatus"].Value.ToString(), dGVTipoEntidad.CurrentRow.Cells["NoEliminable"].Value.ToString(),
                                                                           dGVTipoEntidad.CurrentRow.Cells["IdGrupoEntidad"].Value.ToString());
                DialogResult dialogResult = editar.ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    MostrarTabla();
                }
            }
            else
            {
                MessageBox.Show("Debes seleccionar una fila");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dGVTipoEntidad.SelectedRows.Count > 0)
            {
                if (objTipoEntidad.Eliminar(dGVTipoEntidad.CurrentRow.Cells["IdTipoEntidad"].Value.ToString())){
                    MessageBox.Show("Eliminacion exitosa");
                    MostrarTabla();
                }
                else { MessageBox.Show("Ha ocurrido un error inesperado, no se a podido eliminar el dato."); }
            }
            else
            {
                MessageBox.Show("Debes seleccionar una fila");
            }
        }
    }
}
