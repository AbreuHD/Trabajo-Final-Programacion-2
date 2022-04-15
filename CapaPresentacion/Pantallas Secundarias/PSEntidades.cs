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

namespace CapaPresentacion.Pantallas_Secundarias
{
    public partial class PSEntidades : Form
    {
        String accion;
        String botonInfo;
        String userNameEntidad; 
        String passworEntidad; 
        String descripcion;
        String direccion; 
        String localidad; 
        String tipoEntidad; 
        String tipoDocumento;
        int numeroDocumento; 
        String telefono; 
        String uRLPaginaWeb; 
        String uRLFacebook;
        String uRLInstagram; 
        String uRLTwitter; 
        String uRLTikTok; 
        int idGrupoEntidad;
        int idTipoEntidad; 
        int limiteCredito; 
        String rolUserEntidad; 
        String comentario;
        int sStatus;
        //int noEliminable;
        public PSEntidades(String accion, String botonInfo, String userNameEntidad = "", String passworEntidad = "", String descripcion = "",
                            String direccion = "", String localidad = "", String tipoEntidad = "", String tipoDocumento = "",
                            String telefono = "", String uRLPaginaWeb = "", String uRLFacebook = "",
                            String numeroDocumento = "0", String uRLInstagram = "", String uRLTwitter = "", String uRLTikTok = "",
                            String comentario = "")
        /*int idTipoEntidad = 0, int limiteCredito = 0, int idGrupoEntidad = 0, int sStatus = 0,  String rolUserEntidad = "", String noEliminable = "0"*/

        {
            this.accion = accion;
            this.botonInfo = botonInfo;
            this.userNameEntidad = userNameEntidad;
            this.passworEntidad = passworEntidad;
            this.descripcion = descripcion;
            this.direccion = direccion;
            this.localidad = localidad;//a
            //this.tipoEntidad = tipoEntidad;
            //this.tipoDocumento = tipoDocumento;//a
            this.numeroDocumento = (int)Convert.ToInt64(numeroDocumento);
            this.telefono = telefono;
            this.uRLPaginaWeb = uRLPaginaWeb;
            this.uRLFacebook = uRLFacebook;
            this.uRLInstagram = uRLInstagram;
            this.uRLTwitter = uRLTwitter;
            this.uRLTikTok = uRLTikTok;
            //this.idGrupoEntidad = idGrupoEntidad;
            //this.idTipoEntidad = idTipoEntidad;
            //this.limiteCredito = limiteCredito;
            //this.rolUserEntidad = rolUserEntidad;
            this.comentario = comentario;
            //this.sStatus = sStatus;
            //this.noEliminable = 1*Convert.ToInt16(noEliminable);

            InitializeComponent();
        }

        private void PSEntidades_Load(object sender, EventArgs e)
        {
            labelEntidades.Text = accion;
            btnAceptar.Text = botonInfo;
            tBUsuario.Text = userNameEntidad;
            tBPassword.Text = passworEntidad;
            tBDescripcion.Text = descripcion;
            tbDireccion.Text = direccion;
            tBLocalidad.Text = localidad;
            tBNumeroDocumento.Text = Convert.ToString(numeroDocumento);
            tBTelefono.Text = telefono;
            tBPaginaWeb.Text = uRLPaginaWeb;
            tBFacebook.Text = uRLFacebook;
            tBInstagram.Text = uRLInstagram;
            tBTwitter.Text = uRLTwitter;
            tBTikTok.Text = uRLTikTok;
            tBComentario.Text = comentario;
            /*if(noEliminable == 1)
            {
                rBEliminable.Select();
            }*/
        }

    }
}
