﻿using System;
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
        String estatus;
        bool check;
        int grupoEntidad;
        CNTipoEntidad objTipoEntidad = new CNTipoEntidad(); 
        public PSTiposEntidades(String accion, String btn, String id = "0", String descripcion = "",
                                String comentario = "", String estatus = "Activa", String check = "false", String grupoEntidad = "1")
        {
            this.descripcion = descripcion;
            this.comentario = comentario;
            this.id = id;
            this.accion = accion;
            this.btn = btn;
            this.estatus = estatus;
            this.check = Convert.ToBoolean(check.ToLower());
            this.grupoEntidad = Convert.ToInt32(grupoEntidad);
            InitializeComponent();
        }

        private void PSTiposEntidades_Load(object sender, EventArgs e)
        {
            if (estatus == "Activa")
            {
                cBEstatus.SelectedIndex = 0;
            }
            else { cBEstatus.SelectedIndex = 1; }

            if (check)
            {
                cBEliminable.Checked = true;
            }
            cBGrupoEntidad.SelectedIndex = grupoEntidad-1;
            tBComentario.Text = comentario;
            tbDescripcion.Text = descripcion;
            lbPrincipal.Text = accion;
            btnAceptar.Text = btn;
            //cBEliminable.
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int eliminable = 0;

            if (cBEliminable.Checked)
            {
                eliminable = 1;
            }
            else { eliminable = 0; }

            if (lbPrincipal.Text == "Crear tipo entidades")
            {
                if (objTipoEntidad.AddTipos(tbDescripcion.Text,cBGrupoEntidad.Text,tBComentario.Text, cBEstatus.Text, eliminable))
                {
                    MessageBox.Show("Se ha creado con exito");
                }
                else { MessageBox.Show("Ha ocurrido un error, no se a podio crear."); }
            }
            else
            {
                if (objTipoEntidad.EditTipos(id, tbDescripcion.Text, cBGrupoEntidad.Text, tBComentario.Text, cBEstatus.Text, eliminable))
                {
                    MessageBox.Show("Se ha editado con exito");
                }
                else { MessageBox.Show("Ha ocurrido un error, no se a podido editar."); }
            }
        }
    }
}