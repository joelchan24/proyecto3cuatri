using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAO;
using BO;
using Services;

namespace AdministradorGUI
{
    public partial class Usuario1 : System.Web.UI.Page
    {
        usuarioDAO objusuario = new usuarioDAO();
        UsuarioBO objbo = new UsuarioBO();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ListarPais();
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

        }
    }
}