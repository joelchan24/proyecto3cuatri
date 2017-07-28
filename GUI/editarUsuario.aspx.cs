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

namespace GUI
{
    public partial class editarUsuario : System.Web.UI.Page
    {
        loginDAO login = new loginDAO();
        LitarTODO objeditar = new LitarTODO();
        public int id;
        usuarioDAO objusuario = new usuarioDAO();
        ctrol_usuarioSERVICIOS ctrlusu = new ctrol_usuarioSERVICIOS();
        string nombrefoto = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    vista();
                    MunicipioCuenta();
                    dgvEditarUsuario.HeaderRow.Cells[2].Text = "Nombre";
                    dgvEditarUsuario.HeaderRow.Cells[3].Text = "Apellidos";
                    dgvEditarUsuario.HeaderRow.Cells[6].Text = "Correo ";
                    dgvEditarUsuario.HeaderRow.Cells[7].Text = "Usuario";
                    dgvEditarUsuario.HeaderRow.Cells[12].Text = "Colonia";
                    dgvEditarUsuario.HeaderRow.Cells[13].Text = "Código Postal";
                    dgvEditarUsuario.HeaderRow.Cells[19].Text = "Municipio";
                    dgvEditarUsuario.HeaderRow.Cells[21].Text = "Tipo de usuario ";
                }
            }
            catch { }

        }
        public UsuarioBO recolectar()
        {
            UsuarioBO obj = new UsuarioBO();
            int id = 0; int.TryParse(txtID.Value, out id);
            obj.Codigo = id;
            obj.Nombre = txtNombre.Text;
            obj.Apellidos = txtapellidos.Text;
            obj.FechaNacimineto = Convert.ToDateTime(txtFecha.Text);
            obj.Telefono = TxtTelefono.Text;
            obj.Correo = txtCorreo.Text;
            obj.IDCUENTA = Convert.ToInt32(ddlTipoUsuario.SelectedValue);
            obj.Usuario = txtusuario.Text;
            obj.Contraseña = txtContraseña.Text;
            obj.CodigoMunicipio = Convert.ToInt32(ddlMunicipio.SelectedValue);
            obj.Colonia = txtColonia.Text;
            obj.CodigoPostal = txtCOdigoPostal.Text;
            obj.Cruzamiento = txtCruzamiento.Text;
            obj.NumeroInterior = txtNumeroInterior.Text;
            obj.NumeroExterior = txtNumeroExteriror.Text;
            obj.Fotografia = nombrefoto;
            return obj;
        }
        public void vista()
        {
            try
            {


                txtID.Value = Session["id"].ToString();
                id = int.Parse(txtID.Value);
                dgvEditarUsuario.DataSource = objeditar.listarNombre(id);
                dgvEditarUsuario.DataBind();
            }
            catch { }
        }
        public void MunicipioCuenta()
        {
            try
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
            catch { }
        }

        protected void seleccionar(object sender, GridViewCommandEventArgs e)
        {
            try
            {
                int selec = Convert.ToInt32(e.CommandArgument.ToString());
                txtID.Value = dgvEditarUsuario.Rows[selec].Cells[1].Text;
                txtNombre.Text = dgvEditarUsuario.Rows[selec].Cells[2].Text;
                txtapellidos.Text = dgvEditarUsuario.Rows[selec].Cells[3].Text;
                TxtTelefono.Text = dgvEditarUsuario.Rows[selec].Cells[4].Text;
                //DateTime fecha = Convert.ToDateTime(dgvEditarUsuario.Rows[selec].Cells[5].Text);
                //txtFecha.Text = fecha.ToString();
                txtFecha.Text = (dgvEditarUsuario.Rows[selec].Cells[5].Text.ToString());
                txtCorreo.Text = dgvEditarUsuario.Rows[selec].Cells[6].Text;
                txtusuario.Text = dgvEditarUsuario.Rows[selec].Cells[7].Text;
                txtContraseña.Text = dgvEditarUsuario.Rows[selec].Cells[8].Text;
                imgFoto.ImageUrl = "img/" + dgvEditarUsuario.Rows[selec].Cells[9].Text.ToString() + ".jpg";
                txtColonia.Text = dgvEditarUsuario.Rows[selec].Cells[12].Text;
                txtCOdigoPostal.Text = dgvEditarUsuario.Rows[selec].Cells[13].Text;
                txtCruzamiento.Text = dgvEditarUsuario.Rows[selec].Cells[14].Text;
                txtNumeroInterior.Text = dgvEditarUsuario.Rows[selec].Cells[15].Text;
                txtNumeroExteriror.Text = dgvEditarUsuario.Rows[selec].Cells[16].Text;
                // ddlMunicipio.SelectedValue = dgvEditarUsuario.Rows[selec].Cells[19].Text;
                // ddlTipoUsuario.SelectedValue = dgvEditarUsuario.Rows[selec].Cells[21].Text;
            }
            catch { }

        }

        protected void ocultar(object sender, GridViewRowEventArgs e)
        {
            try
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
            catch { }
        }

        protected void seleccionar(object sender, EventArgs e)
        {
            try
            {
                Button selec = (Button)sender;
                if (selec.ID == "btnModificar")
                {
                    if (file_foto.HasFile)
                    {
                        File.Delete(MapPath(imgFoto.ImageUrl));
                        nombrefoto = NombreImagen();
                        file_foto.SaveAs(Server.MapPath("~/img/") + nombrefoto + ".jpg");
                    }
                    //FileUploadFoto.Save("miimagen.jpg",ImageFormat.Jpeg);
                }
                ctrlusu.accion1(recolectar(), selec.ID);
                vista();
                Response.Write("<script>window.alert('Bien hecho');<script>");
            }
            catch
            {
                Response.Write("<script>window.alert('Aocurrido un error intentelo de nuevo');<script>");
            }
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
    }
}