using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaPresentacion.Pantallas_Secundarias;
using NetFramework.Layers.ADO.Net.CapaNegocio;

namespace CapaPresentacion
{
    public partial class CPEntidades : Form
    {

        public CPEntidades()
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
            PSEntidades crear = new PSEntidades("Crear Entidad", "Agregar");
            DialogResult dialogResult  = crear.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                MostrarEntidades();
            }
            //crear.Show();

        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            if(dGEntidades.SelectedRows.Count > 0)
            {
                PSEntidades editar = new PSEntidades("Editar Entidades", "Editar", dGEntidades.CurrentRow.Cells["UserNameEntidad"].Value.ToString(),
                dGEntidades.CurrentRow.Cells["PassworEntidad"].Value.ToString(), dGEntidades.CurrentRow.Cells["Descripcion"].Value.ToString(),
                dGEntidades.CurrentRow.Cells["Direccion"].Value.ToString(), dGEntidades.CurrentRow.Cells["Localidad"].Value.ToString(),
                dGEntidades.CurrentRow.Cells["TipoEntidad"].Value.ToString(), dGEntidades.CurrentRow.Cells["TipoDocumento"].Value.ToString(),
                dGEntidades.CurrentRow.Cells["Teléfonos"].Value.ToString(), dGEntidades.CurrentRow.Cells["URLPaginaWeb"].Value.ToString(),
                dGEntidades.CurrentRow.Cells["URLFacebook"].Value.ToString(), dGEntidades.CurrentRow.Cells["NumeroDocumento"].Value.ToString(),
                dGEntidades.CurrentRow.Cells["URLInstagram"].Value.ToString(), dGEntidades.CurrentRow.Cells["URLTwitter"].Value.ToString(),
                dGEntidades.CurrentRow.Cells["URLTikTok"].Value.ToString(), dGEntidades.CurrentRow.Cells["Comentario"].Value.ToString(),
                dGEntidades.CurrentRow.Cells["IdEntidad"].Value.ToString(), dGEntidades.CurrentRow.Cells["SStatus"].Value.ToString(),
                dGEntidades.CurrentRow.Cells["RolUserEntidad"].Value.ToString(), dGEntidades.CurrentRow.Cells["LimiteCredito"].Value.ToString(),
                dGEntidades.CurrentRow.Cells["IdTipoEntidad"].Value.ToString(), dGEntidades.CurrentRow.Cells["IdGrupoEntidad"].Value.ToString(),
                dGEntidades.CurrentRow.Cells["NoEliminable"].Value.ToString()
                );
                DialogResult dialogResult = editar.ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    MostrarEntidades();
                }
                //editar.Show();
            }
            else
            {
                MessageBox.Show("Debes seleccionar una de las tablas");
            }
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            if(dGEntidades.SelectedRows.Count > 0)
            {
                CNEntidad objEntidadDelete = new CNEntidad();
                if(Convert.ToBoolean(dGEntidades.CurrentRow.Cells["NoEliminable"].Value.ToString().ToLower()))
                {
                    MessageBox.Show("Esta entidad no se puede eliminar por que asi esta guardada.");
                }
                else
                {
                    if (objEntidadDelete.Eliminar(dGEntidades.CurrentRow.Cells["IdEntidad"].Value.ToString()))
                    {
                        MessageBox.Show("Se ha eliminado correctamente");
                        MostrarEntidades();
                    }
                    else { MessageBox.Show("A ocurrido un error inesperado, no se a podido eliminar."); }
                }
            }
            else
            {
                MessageBox.Show("Debes selecciona una de las tablas");
            }
        }
    }
}
