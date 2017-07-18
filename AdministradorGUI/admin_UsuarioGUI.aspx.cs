using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AdministradorGUI
{
    public partial class Usuario : System.Web.UI.Page
    {
        usuarioDAO objusuario = new usuarioDAO();
        UsuarioBO objbo = new UsuarioBO();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
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
            obj.Nombre = txtNombre.Text;
            obj.Apellidos = txtApellido.Text;
            return obj;
        }
    }
}