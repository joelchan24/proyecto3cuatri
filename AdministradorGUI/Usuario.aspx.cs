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
            UsuarioBO obj = new UsuarioBO();
            int id = 0; int.TryParse(txtID.Text, out id);
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
            return obj;
        }

        protected void accion1(object sender, EventArgs e)
        {
            Button obj = (Button)sender;
            ctrl.accion1(recolectar(), obj.ID);


        }
    }
}