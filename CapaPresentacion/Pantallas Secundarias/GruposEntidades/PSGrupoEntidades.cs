using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaPresentacion;

namespace CapaPresentacion.Pantallas_Secundarias
{
    public partial class PSGrupoEntidades : Form
    {
        NetFramework.Layers.ADO.Net.CapaNegocio.CNGruposEntidades objeGrupoEntidades = new NetFramework.Layers.ADO.Net.CapaNegocio.CNGruposEntidades();
        String accion;
        String btn;
        String id;
        String descripcion;
        String comentario;

        public PSGrupoEntidades(String accion, String btn, String id = "0", String descripcion = "", 
                                String comentario = "")
        {
            this.descripcion = descripcion;
            this.comentario = comentario;
            this.id = id;
            this.accion = accion;
            this.btn = btn;
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            
            int eliminable = 0;

            if (cBEstatus.Enabled)
            {
                MessageBox.Show(eliminable + " no soy elimiable e");
                eliminable = 1;

            }
            else { eliminable = 0; }

            if (lbInfoPantalla.Text == "Crear Grupo Entidades")
            {
                if (objeGrupoEntidades.AddDatos(tBDescripcion.Text, tBComentario.Text, cBEstatus.Text, eliminable))
                {
                    MessageBox.Show("Se ha creado con exito");
                }
            }else
            {
                if (objeGrupoEntidades.EditDatos(id, tBDescripcion.Text, tBComentario.Text, cBEstatus.Text, eliminable))
                {
                    MessageBox.Show("Se ha editado con exito");
                }
            }
        }

        private void PSGrupoEntidades_Load(object sender, EventArgs e)
        {
            lbInfoPantalla.Text = accion;
            btnAceptar.Text = btn;
            tBDescripcion.Text = descripcion;
            tBComentario.Text = comentario;
        }
    }
}
