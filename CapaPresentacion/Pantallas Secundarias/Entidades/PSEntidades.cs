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

namespace CapaPresentacion.Pantallas_Secundarias
{
    public partial class PSEntidades : Form
    {
        CNEntidad objEntidad = new CNEntidad();

        int id;
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

        public PSEntidades( String accion = "", String botonInfo = "", String userNameEntidad = "", String passworEntidad = "", String descripcion = "",
                            String direccion = "", String localidad = "", String tipoEntidad = "", String tipoDocumento = "",
                            String telefono = "", String uRLPaginaWeb = "", String uRLFacebook = "",
                            String numeroDocumento = "0", String uRLInstagram = "", String uRLTwitter = "", String uRLTikTok = "",
                            String comentario = "", String id = "0")
        /*int idTipoEntidad = 0, int limiteCredito = 0, int idGrupoEntidad = 0, int sStatus = 0,  String rolUserEntidad = "", String noEliminable = "0"*/

        {
            DataTable dt = new DataTable();

     
            //cBIDTipoEntidad.DataSource = objEntidad.BuscarIDTiposEntidades();


            this.id = int.Parse(id);
            this.accion = accion;
            this.botonInfo = botonInfo;
            this.userNameEntidad = userNameEntidad;
            this.passworEntidad = passworEntidad;
            this.descripcion = descripcion;
            this.direccion = direccion;
            this.localidad = localidad;
            //this.tipoEntidad = tipoEntidad;
            //this.tipoDocumento = tipoDocumento;
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
                                  tBInstagram.Text, tBTwitter.Text, tBTikTok.Text, tBComentario.Text, cBIDTipoEntidad.Text, nUDLimiteCredito.Value.ToString(),
                                  cBGrupoEntidad.Text, cBStatus.Text, cBRolUserEntidad.Text, eliminable))
                {
                    MessageBox.Show("Editado con exito");
                }
                else { MessageBox.Show("Ha ocurrido un error y no se a podido editar."); }
            }
            else
            {
                if (objEntidad.Crear(tBUsuario.Text, tBPassword.Text, tBDescripcion.Text, tbDireccion.Text, tBLocalidad.Text, cBTipoEntidad.Text,
                                  cBTipoDeDocumento.Text, tBTelefono.Text, tBPaginaWeb.Text, tBFacebook.Text, tBNumeroDocumento.Text,
                                  tBInstagram.Text, tBTwitter.Text, tBTikTok.Text, tBComentario.Text, cBIDTipoEntidad.Text, "1",
                                  cBGrupoEntidad.Text, cBStatus.Text, cBRolUserEntidad.Text, eliminable))
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
