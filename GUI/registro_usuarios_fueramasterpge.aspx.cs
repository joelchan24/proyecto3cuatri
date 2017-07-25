using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Services;
using BO;
using DAO;
using System.Security.Cryptography;
using System.Text;

namespace GUI
{
    public partial class registro_usuarios_fueramasterpge : System.Web.UI.Page
    {
        ctrol_usuarioSERVICIOS ctrlusu = new ctrol_usuarioSERVICIOS();
        usuarioDAO usudao = new usuarioDAO();
        UsuarioBO usubo = new UsuarioBO();
        string nombrefoto = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {


                if (!IsPostBack)
                {
                    listrusuario();
                }
            }catch
            {

            }
        }

        protected void accion1(object sender, EventArgs e)
        {
            try
            {


                Button selec = (Button)sender;
                if (selec.ID == "btnAgregar")
                {
                    if (file_foto.HasFile)
                    {
                        nombrefoto = NombreImagen();
                        file_foto.SaveAs(Server.MapPath("~/img/") + nombrefoto + ".jpg");
                    }
                    //FileUploadFoto.Save("miimagen.jpg",ImageFormat.Jpeg);
                }
                ctrlusu.accion1(colectar(), selec.ID);
                limpiarcontroles();
            }
            catch
            {

            }


        }
        public UsuarioBO colectar()
        {
            
            
            int id = 0; int.TryParse(txtID.Value, out id);
            usubo.Codigo = id;
            usubo.Nombre = txtNombre.Text;
            usubo.Apellidos = txtapellidos.Text;
            usubo.FechaNacimineto = Convert.ToDateTime(txtFecha.Text);
            usubo.Telefono = TxtTelefono.Text;
            usubo.Correo = txtCorreo.Text;
            usubo.IDCUENTA = Convert.ToInt32(ddlTipoUsuario.SelectedValue);
            usubo.Usuario = txtUsuario.Text;
            usubo.Contraseña = txtContraseña.Text;
            usubo.CodigoMunicipio = Convert.ToInt32(ddlMunicipio.SelectedValue);
            usubo.Colonia = txtColonia.Text;
            usubo.CodigoPostal = txtCOdigoPostal.Text;
            usubo.Cruzamiento = txtCruzamiento.Text;
            usubo.NumeroInterior = txtNumeroInterior.Text;
            usubo.NumeroExterior = txtNumeroExteriror.Text;
            usubo.Fotografia = nombrefoto;
            return usubo;
        }
        public string NombreImagen()
        {
            


                DateTime tiempo = DateTime.Now;
                MD5 md5 = MD5CryptoServiceProvider.Create();
                ASCIIEncoding encoding = new ASCIIEncoding();
                byte[] stream = null;
                StringBuilder sb = new StringBuilder();
                stream = md5.ComputeHash(encoding.GetBytes(tiempo.ToString(System.Globalization.CultureInfo.InvariantCulture)));
                for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
                return sb.ToString();
           
        }
        public void listrusuario()
        {
            try
            {
                ddlTipoUsuario.DataSource = usudao.listarusuario().Tables[0];
                ddlTipoUsuario.DataTextField = "NOMBRE";
                ddlTipoUsuario.DataValueField = "CODIGO";
                ddlTipoUsuario.DataBind();
                ddlMunicipio.DataSource = usudao.listarMunicipio().Tables[0];
                ddlMunicipio.DataTextField = "NOMBRE";
                ddlMunicipio.DataValueField = "CODIGO";
                ddlMunicipio.DataBind();
            }
            catch
            {

            }
        }
        
        public void limpiarcontroles()
        {
            try
            {
                txtNombre.Text = "";
                txtapellidos.Text = "";
                TxtTelefono.Text = "";
                txtFecha.Text = "01/01/2017";
                txtCorreo.Text = "";
                ddlMunicipio.SelectedValue = "";
                txtColonia.Text = "";
                txtCOdigoPostal.Text = "";
                txtUsuario.Text = "";
                txtContraseña.Text = "";
                txtCruzamiento.Text = "";
                txtNumeroInterior.Text = "";
                txtNumeroExteriror.Text = "";
            }
            catch
            {

            }


        }
    }
}