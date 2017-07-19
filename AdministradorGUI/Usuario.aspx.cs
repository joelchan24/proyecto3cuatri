using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAO;
using BO;
using Services;
using System.Security.Cryptography;
using System.Text;
using System.IO;

namespace AdministradorGUI
{
    public partial class Usuario1 : System.Web.UI.Page
    {
        usuarioDAO objusuario = new usuarioDAO();
        UsuarioBO objbo = new UsuarioBO();
        ctrol_usuarioSERVICIOS ctrl = new ctrol_usuarioSERVICIOS();
        string strNuevoNombre="";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ListarPais();
                vista();
            }

        }
        public void ListarPais()
        {
            ddlTipousuario.DataSource = objusuario.listarusuario().Tables[0];
            ddlTipousuario.DataTextField = "NOMBRE";
            ddlTipousuario.DataValueField = "CODIGO";
            ddlTipousuario.DataBind();
            ddlMunicipio.DataSource = objusuario.listarMunicipio().Tables[0];
            ddlMunicipio.DataTextField = "NOMBRE";
            ddlMunicipio.DataValueField = "CODIGO";
            ddlMunicipio.DataBind();
        }

        public UsuarioBO recolectar()
        {
            UsuarioBO obj = new UsuarioBO();
            int id = 0; int.TryParse(txtID.Text, out id);
            obj.Codigo = id;
            obj.Nombre = txtNombre.Text;
            obj.Apellidos = txtApellido.Text;
            obj.FechaNacimineto =Convert.ToDateTime( txtfecha.Text);
            obj.Telefono = txtTelefono.Text;
            obj.Correo = txtCorreo.Text;
            obj.IDCUENTA = Convert.ToInt32(ddlTipousuario.SelectedValue);
            obj.Usuario = txtUsuario.Text;
            obj.Contraseña = txtContraseña.Text;
            obj.CodigoMunicipio = Convert.ToInt32(ddlMunicipio.SelectedValue);
            obj.Colonia = txtColonia.Text;
            obj.CodigoPostal = txtCodigoPostal.Text;
            obj.Cruzamiento = txtCruzamiento.Text;
            obj.NumeroInterior = txtNumeroInterior.Text;
            obj.NumeroExterior = txtNumeroExteriror.Text;
            obj.Fotografia = strNuevoNombre;
            return obj;
        }

        protected void accion1(object sender, EventArgs e)
        {
            Button obj = (Button)sender;
            if (obj.ID == "btnAgregar")
            {
                if (file_foto.HasFile)
                {
                    strNuevoNombre = NombreImagen();
                    file_foto.SaveAs(Server.MapPath("~/img/") + strNuevoNombre + ".jpg");
                }
                //FileUploadFoto.Save("miimagen.jpg",ImageFormat.Jpeg);
            }
            ctrl.accion1(recolectar(), obj.ID);

            vista();
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
        public void vista()
        {
            dtgDatos.DataSource = objusuario.LISTARDATOS().Tables[0];
            dtgDatos.DataBind();
        }

        protected void accion(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "btnSeleccionar")
            {
                int indice = Convert.ToInt32(e.CommandArgument);
                txtID.Text= dtgDatos.Rows[indice].Cells[1].Text.ToString();
                imgFoto.ImageUrl = "img/" + dtgDatos.Rows[indice].Cells[9].Text.ToString() + ".jpg";
            }
        }
    }
}