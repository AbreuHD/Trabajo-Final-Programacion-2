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
using NetFramework.Layers.CapaDatos;

namespace CapaPresentacion.Pantallas_Secundarias
{
    public partial class PSEntidades : Form
    {
        CNEntidad objEntidad = new CNEntidad();
        CNGruposEntidades objGrupoEntidad = new CNGruposEntidades();
        CNTipoEntidad objTipoEntidad = new CNTipoEntidad();

        int id;
        int idGrupoEntidad;
        int idTipoEntidad;
        int limiteCredito;
        int numeroDocumento;
        bool eliminable;
        String accion;
        String botonInfo;
        String userNameEntidad; 
        String passworEntidad; 
        String descripcion;
        String direccion; 
        String localidad; 
        String tipoEntidad; 
        String tipoDocumento;
        String telefono; 
        String uRLPaginaWeb; 
        String uRLFacebook;
        String uRLInstagram; 
        String uRLTwitter; 
        String uRLTikTok; 
        String rolUserEntidad; 
        String comentario;
        String sStatus;

        public PSEntidades( String accion = "", String botonInfo = "", String userNameEntidad = "", String passworEntidad = "", String descripcion = "",
                            String direccion = "", String localidad = "", String tipoEntidad = "0", String tipoDocumento = "0",
                            String telefono = "", String uRLPaginaWeb = "", String uRLFacebook = "",
                            String numeroDocumento = "0", String uRLInstagram = "", String uRLTwitter = "", String uRLTikTok = "",
                            String comentario = "", String id = "0", String sstatus = "0", String rolUserEntidad = "User", String limiteCredito = "1",
                            String idTipoEntidad = "1", String idGrupoEntidad = "1", String eliminable = "False")

        {
            DataTable dt = new DataTable();

            this.id = int.Parse(id);
            this.accion = accion;
            this.botonInfo = botonInfo;
            this.userNameEntidad = userNameEntidad;
            this.passworEntidad = passworEntidad;
            this.descripcion = descripcion;
            this.direccion = direccion;
            this.localidad = localidad;
            this.tipoEntidad = tipoEntidad;
            this.tipoDocumento = tipoDocumento;
            this.numeroDocumento = (int)Convert.ToInt64(numeroDocumento);
            this.telefono = telefono;
            this.uRLPaginaWeb = uRLPaginaWeb;
            this.uRLFacebook = uRLFacebook;
            this.uRLInstagram = uRLInstagram;
            this.uRLTwitter = uRLTwitter;
            this.uRLTikTok = uRLTikTok;
            this.idGrupoEntidad = Convert.ToInt32(idGrupoEntidad);
            this.idTipoEntidad = Convert.ToInt32(idTipoEntidad);
            this.limiteCredito = Convert.ToInt32(limiteCredito);
            this.rolUserEntidad = rolUserEntidad;
            this.comentario = comentario;
            this.sStatus = sstatus;
            this.eliminable = Convert.ToBoolean(eliminable.ToLower());
            InitializeComponent();
        }

        private void PSEntidades_Load(object sender, EventArgs e)
        {
            if(tipoEntidad == "Fisico"){cBTipoEntidad.SelectedIndex = 0;}
            else { cBTipoEntidad.SelectedIndex = 1; }

            if (tipoDocumento == "Cédula") { cBTipoDeDocumento.SelectedIndex = 1; }
            else if (tipoDocumento == "Pasaporte") { cBTipoDeDocumento.SelectedIndex = 2; }
            else { cBTipoDeDocumento.SelectedIndex = 0; }

            if (sStatus == "Inactiva") { cBStatus.SelectedIndex = 1; }
            else { cBStatus.SelectedIndex = 0; }

            if (rolUserEntidad == "Admin") { cBRolUserEntidad.SelectedIndex = 0; }
            else if (rolUserEntidad == "Supervisor") { cBRolUserEntidad.SelectedIndex = 1; }
            else { cBRolUserEntidad.SelectedIndex = 2; }

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
            nUDLimiteCredito.Value = limiteCredito;
            rBEliminable.Checked = eliminable;

            MessageBox.Show(Convert.ToString(idGrupoEntidad));
            cBGrupoEntidad.DataSource = objGrupoEntidad.MostrarEntidades();
            cBGrupoEntidad.ValueMember = "IdGrupoEntidad";
            cBGrupoEntidad.DisplayMember = "Descripcion";
            try
            {
                cBGrupoEntidad.SelectedIndex = idGrupoEntidad - 1; ;
            }
            catch (Exception ex) { throw ex; }
            

            cBIDTipoEntidad.DataSource = objTipoEntidad.MostrarTipoEntidades();
            cBIDTipoEntidad.ValueMember = "IdTipoEntidad";
            cBIDTipoEntidad.DisplayMember = "Descripcion";
            try
            {
                cBIDTipoEntidad.SelectedIndex = idTipoEntidad-1;
            }
            catch (Exception ex) { throw ex; }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int eliminable = 0;
            if (rBEliminable.Checked == true)
            {
                eliminable = 1;
            }
            else
            {
                eliminable = 0;
            }

            if (accion == "Editar Entidades")
            {
               if(objEntidad.Editar(id, tBUsuario.Text, tBPassword.Text, tBDescripcion.Text, tbDireccion.Text, tBLocalidad.Text, cBTipoEntidad.Text,
                                  cBTipoDeDocumento.Text, tBTelefono.Text, tBPaginaWeb.Text, tBFacebook.Text, tBNumeroDocumento.Text,
                                  tBInstagram.Text, tBTwitter.Text, tBTikTok.Text, tBComentario.Text, cBIDTipoEntidad.SelectedValue.ToString(), nUDLimiteCredito.Value.ToString(),
                                  cBGrupoEntidad.SelectedValue.ToString(), cBStatus.Text, cBRolUserEntidad.Text, eliminable))
                {
                    MessageBox.Show("Editado con exito");
                }
                else { MessageBox.Show("Debes llenar todos los campos."); }
            }
            else
            {
                if (objEntidad.Crear(tBUsuario.Text, tBPassword.Text, tBDescripcion.Text, tbDireccion.Text, tBLocalidad.Text, cBTipoEntidad.Text,
                                  cBTipoDeDocumento.Text, tBTelefono.Text, tBPaginaWeb.Text, tBFacebook.Text, tBNumeroDocumento.Text,
                                  tBInstagram.Text, tBTwitter.Text, tBTikTok.Text, tBComentario.Text, cBIDTipoEntidad.SelectedValue.ToString(), nUDLimiteCredito.Value.ToString(),
                                  cBGrupoEntidad.SelectedValue.ToString(), cBStatus.Text, cBRolUserEntidad.Text, eliminable))
                {
                    MessageBox.Show("Creacion Exitosa.");
                }
                else { MessageBox.Show("Ha ocurrido un error, no se a podido crear."); }

            }

            
        }

        private void tBUsuario_Validated(object sender, EventArgs e)
        {
            if (tBUsuario.Text == string.Empty)
            {
                epError.SetError(tBUsuario, "Escribe un nombre de usuario.");
                tBUsuario.Focus();
            }
            else
            {
                epError.Clear();
            }
        }

        private void tBPassword_Validated(object sender, EventArgs e)
        {
            if (tBPassword.Text == string.Empty)
            {
                epError.SetError(tBPassword, "Escribe una contraseña.");
                tBPassword.Focus();
            }
            else
            {
                epError.Clear();
            }

        }

        private void tbDireccion_Validated(object sender, EventArgs e)
        {
            if (tbDireccion.Text == string.Empty)
            {
                epError.SetError(tbDireccion, "Escribe una direccion.");
                tbDireccion.Focus();
            }
            else
            {
                epError.Clear();
            }

        }

        private void tBLocalidad_Validated(object sender, EventArgs e)
        {
            if (tBLocalidad.Text == string.Empty)
            {
                epError.SetError(tBLocalidad, "Escribe una localidad.");
                tBLocalidad.Focus();
            }
            else
            {
                epError.Clear();
            }

        }

        private void tBNumeroDocumento_Validated(object sender, EventArgs e)
        {
            if (tBNumeroDocumento.Text == string.Empty)
            {
                epError.SetError(tBNumeroDocumento, "Debes ingresar tu numero de documento.");
                tBNumeroDocumento.Focus();
            }
            else
            {
                epError.Clear();
            }
        }

        private void tBTelefono_Validated(object sender, EventArgs e)
        {
            if (tBTelefono.Text == string.Empty)
            {
                epError.SetError(tBTelefono, "Debes ingresar tu numero de telefono.");
                tBTelefono.Focus();
            }
            else
            {
                epError.Clear();
            }

        }

        private void tBPaginaWeb_Validated(object sender, EventArgs e)
        {
            if (tBPaginaWeb.Text == string.Empty)
            {
                epError.SetError(tBPaginaWeb, "Debes ingresar una pagina web.");
                tBPaginaWeb.Focus();
            }
            else
            {
                epError.Clear();
            }
        }

        private void tBFacebook_Validated(object sender, EventArgs e)
        {
            if (tBFacebook.Text == string.Empty)
            {
                epError.SetError(tBFacebook, "Debes ingresar una url de FaceBook.");
                tBFacebook.Focus();
            }
            else
            {
                epError.Clear();
            }

        }

        private void tBInstagram_Validated(object sender, EventArgs e)
        {
            if (tBInstagram.Text == string.Empty)
            {
                epError.SetError(tBInstagram, "Debes ingresar una url de Instagram.");
                tBInstagram.Focus();
            }
            else
            {
                epError.Clear();
            }
        }

        private void tBTwitter_Validated(object sender, EventArgs e)
        {
            if (tBTwitter.Text == string.Empty)
            {
                epError.SetError(tBTwitter, "Debes ingresar una url de Twitter.");
                tBTwitter.Focus();
            }
            else
            {
                epError.Clear();
            }
        }

        private void tBTikTok_Validated(object sender, EventArgs e)
        {
            if (tBTikTok.Text == string.Empty)
            {
                epError.SetError(tBTikTok, "Debes ingresar una url de TikTok.");
                tBTikTok.Focus();
            }
            else
            {
                epError.Clear();
            }
        }
    }
}
