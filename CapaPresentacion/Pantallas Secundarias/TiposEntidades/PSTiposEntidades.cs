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

namespace CapaPresentacion.Pantallas_Secundarias.TiposEntidades
{
    public partial class PSTiposEntidades : Form
    {
        String accion;
        String btn;
        String id;
        String descripcion;
        String comentario;
        CNTipoEntidad objTipoEntidad = new CNTipoEntidad(); 
        public PSTiposEntidades(String accion, String btn, String id = "0", String descripcion = "",
                                String comentario = "")
        {
            this.descripcion = descripcion;
            this.comentario = comentario;
            this.id = id;
            this.accion = accion;
            this.btn = btn;

            InitializeComponent();
        }

        private void PSTiposEntidades_Load(object sender, EventArgs e)
        {
            tBComentario.Text = comentario;
            tbDescripcion.Text = descripcion;
            lbPrincipal.Text = accion;
            btnAceptar.Text = btn;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            int eliminable = 0;

            if (cBEstatus.Enabled)
            {
                MessageBox.Show(eliminable + " no soy elimiable e");
                eliminable = 1;

            }
            else { eliminable = 0; }

            if (lbPrincipal.Text == "Crear tipo entidades")
            {
                if (objTipoEntidad.AddTipos(tbDescripcion.Text,cBGrupoEntidad.Text,tBComentario.Text, cBEstatus.Text, eliminable))
                {
                    MessageBox.Show("Se ha creado con exito");
                }
            }
            else
            {
                if (objTipoEntidad.EditTipos(id, tbDescripcion.Text, cBGrupoEntidad.Text, tBComentario.Text, cBEstatus.Text, eliminable))
                {
                    MessageBox.Show("Se ha editado con exito");
                }
            }
        }
    }
}
