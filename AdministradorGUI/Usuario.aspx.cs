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
        ctrol_usuarioSERVICIOS ctrl = new ctrol_usuarioSERVICIOS();
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
            UsuarioBO objbo = new UsuarioBO();
            int id = 0; int.TryParse(txtID.Text, out id);
            objbo.Codigo = id;
            objbo.Nombre = txtNombre.Text;
            objbo.Apellidos = txtApellido.Text;
            objbo.FechaNacimineto = Convert.ToDateTime(txtfecha.Text);
            objbo.Telefono = txtTelefono.Text;
            objbo.Correo = txtCorreo.Text;
            objbo.IDCUENTA = Convert.ToInt32(ddlTipousuario.SelectedValue);
            objbo.Usuario = txtUsuario.Text;
            objbo.Contraseña = txtContraseña.Text;
            objbo.CodigoMunicipio = Convert.ToInt32(ddlMunicipio.SelectedValue);
            objbo.Colonia = txtColonia.Text;
            objbo.CodigoPostal = txtCodigoPostal.Text;
            objbo.Cruzamiento = txtCruzamiento.Text;
            objbo.NumeroInterior = txtNumeroInterior.Text;
            objbo.NumeroExterior = txtNumeroExteriror.Text;
            return objbo;

        }

        protected void accion1(object sender, EventArgs e)
        {
            Button obj = (Button)sender;
            ctrl.accion1(recolectar(), obj.ID);
        }
    }
}