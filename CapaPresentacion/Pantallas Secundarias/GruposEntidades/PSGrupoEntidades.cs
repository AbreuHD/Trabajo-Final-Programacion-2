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

namespace CapaPresentacion.Pantallas_Secundarias
{
    public partial class PSGrupoEntidades : Form
    {
        CNGruposEntidades objeGrupoEntidades = new CNGruposEntidades();
        String accion;
        String btn;
        String id;
        String descripcion;
        String comentario;
        String estatus;
        bool check;

        public PSGrupoEntidades(String accion, String btn, String id = "0", String descripcion = "",
                                String comentario = "", String estatus = "Activa", String check = "false")
        {
            this.descripcion = descripcion;
            this.comentario = comentario;
            this.id = id;
            this.accion = accion;
            this.btn = btn;
            this.estatus = estatus;
            this.check = Convert.ToBoolean(check.ToLower());
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            
            int eliminable = 0;

            if (cBEliminable.Checked)
            {
                eliminable = 1;

            }
            else { eliminable = 0; }

            if (lbInfoPantalla.Text == "Crear Grupo Entidades")
            {
                if (objeGrupoEntidades.AddDatos(tBDescripcion.Text, tBComentario.Text, cBEstatus.Text, eliminable))
                {
                    MessageBox.Show("Se ha creado con exito");
                }
                else { MessageBox.Show("Ha ocurrido un error, no se a podido crear."); }
            }else
            {
                if (objeGrupoEntidades.EditDatos(id, tBDescripcion.Text, tBComentario.Text, cBEstatus.Text, eliminable))
                {
                    MessageBox.Show("Se ha editado con exito");
                }
                else { MessageBox.Show("Ha ocurrido un error, no se a podido editar."); }
            }
        }

        private void PSGrupoEntidades_Load(object sender, EventArgs e)
        {
            if(estatus == "Activa")
            {
                cBEstatus.SelectedIndex = 0;
            }
            else { cBEstatus.SelectedIndex = 1; }

            if(check)
            {
                cBEliminable.Checked = true;
            }
            else { cBEliminable.Checked = false; }

            lbInfoPantalla.Text = accion;
            btnAceptar.Text = btn;
            tBDescripcion.Text = descripcion;
            tBComentario.Text = comentario;
        }

        private void tBDescripcion_Validated(object sender, EventArgs e)
        {
            if (tBDescripcion.Text == string.Empty)
            {
                epError.SetError(tBDescripcion, "Escribe una descripcion.");
                tBDescripcion.Focus();
            }
            else
            {
                epError.Clear();
            }
        }

        private void tBComentario_Validated(object sender, EventArgs e)
        {
            if (tBComentario.Text == string.Empty)
            {
                epError.SetError(tBComentario, "Escribe un comentario.");
                tBComentario.Focus();
            }
            else
            {
                epError.Clear();
            }
        }
    }
}
