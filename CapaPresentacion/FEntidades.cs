﻿using System;
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
            PSEntidades crear = new PSEntidades("Crear Entidad", "Agregar");
            crear.Show();
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
                dGEntidades.CurrentRow.Cells["URLTikTok"].Value.ToString(), dGEntidades.CurrentRow.Cells["Comentario"].Value.ToString()
                //dGEntidades.CurrentRow.Cells["NoEliminable"].Value.ToString()
                );


                editar.Show();
            }
        }
    }
}
