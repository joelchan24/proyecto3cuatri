using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAO;
using BO;
using Services;

namespace GUI
{
    public partial class editarUsuario : System.Web.UI.Page
    {
        loginDAO login = new loginDAO();
        LitarTODO objeditar = new LitarTODO();
        public int id;
        usuarioDAO objusuario = new usuarioDAO();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                vista();
                MunicipioCuenta();
            }
            

        }
        public void vista()
        {
            txtID.Value = Session["id"].ToString();
            id = int.Parse(txtID.Value);
            dgvEditarUsuario.DataSource = objeditar.listarNombre(id);
            dgvEditarUsuario.DataBind();
        }
        public void MunicipioCuenta()
        { 
            ddlMunicipio.DataSource = objusuario.listarMunicipio().Tables[0];
            ddlMunicipio.DataTextField = "NOMBRE";
            ddlMunicipio.DataValueField = "CODIGO";
            ddlMunicipio.DataBind();
            ddlTipoUsuario.DataSource = objusuario.listarusuario().Tables[0];
            ddlTipoUsuario.DataTextField = "NOMBRE";
            ddlTipoUsuario.DataValueField = "CODIGO";
            ddlTipoUsuario.DataBind();
        }

        protected void seleccionar(object sender, GridViewCommandEventArgs e)
        {
            int selec = Convert.ToInt32(e.CommandArgument.ToString());
            txtID.Value = dgvEditarUsuario.Rows[selec].Cells[1].Text;
            txtNombre.Text = dgvEditarUsuario.Rows[selec].Cells[2].Text;
            txtapellidos.Text = dgvEditarUsuario.Rows[selec].Cells[3].Text;
            TxtTelefono.Text = dgvEditarUsuario.Rows[selec].Cells[4].Text;
            //DateTime fecha = Convert.ToDateTime(dgvEditarUsuario.Rows[selec].Cells[5].Text);
            //txtFecha.Text = fecha.ToString();
            txtFecha.Text =(dgvEditarUsuario.Rows[selec].Cells[5].Text.ToString());
            txtCorreo.Text = dgvEditarUsuario.Rows[selec].Cells[6].Text;
            txtusuario.Text = dgvEditarUsuario.Rows[selec].Cells[7].Text;
            txtContraseña.Text = dgvEditarUsuario.Rows[selec].Cells[8].Text;
            imgFoto.ImageUrl= "img/" + dgvEditarUsuario.Rows[selec].Cells[9].Text.ToString() + ".jpg";
            txtColonia.Text = dgvEditarUsuario.Rows[selec].Cells[12].Text;
            txtCOdigoPostal.Text = dgvEditarUsuario.Rows[selec].Cells[13].Text;
            txtCruzamiento.Text = dgvEditarUsuario.Rows[selec].Cells[14].Text;
            txtNumeroInterior.Text = dgvEditarUsuario.Rows[selec].Cells[15].Text;
            txtNumeroExteriror.Text = dgvEditarUsuario.Rows[selec].Cells[16].Text;
           // ddlMunicipio.SelectedValue = dgvEditarUsuario.Rows[selec].Cells[19].Text;
           // ddlTipoUsuario.SelectedValue = dgvEditarUsuario.Rows[selec].Cells[21].Text;

        }

        protected void ocultar(object sender, GridViewRowEventArgs e)
        {
            e.Row.Cells[1].Visible = false;
            e.Row.Cells[4].Visible = false;
            e.Row.Cells[5].Visible = false;
            e.Row.Cells[8].Visible = false;
            e.Row.Cells[9].Visible = false;
            e.Row.Cells[10].Visible = false;
            e.Row.Cells[11].Visible = false;
            e.Row.Cells[14].Visible = false;
            e.Row.Cells[15].Visible = false;
            e.Row.Cells[16].Visible = false;
            e.Row.Cells[17].Visible = false;
            e.Row.Cells[18].Visible = false;
            e.Row.Cells[20].Visible = false;
        }
    }
}