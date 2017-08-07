using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using BO;
using DAO;
using Services;
using System.Security.Cryptography;
using System.Text;
using System.IO;
namespace GUI
{
    public partial class registroevento : System.Web.UI.Page
    {
        ctrol_dirrecionSERVICIOS ser_direccion = new ctrol_dirrecionSERVICIOS();
        ctrol_eventosSERVICIO control = new ctrol_eventosSERVICIO();
        eventoDAO eventado = new eventoDAO();
        direccionDAO obj = new direccionDAO();
        loginDAO login = new loginDAO();
        string strNuevoNombre = "";
        public   string valor = "0";//cero no aprovado ,1 si aprovado
        int fila;
        int id;

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
               


                txt_usuario.Text = Session["id"].ToString();//jale el id usuario
                id = int.Parse(txt_usuario.Text);

                if (!IsPostBack)
                {

                    ddl_categoria.DataSource = eventado.buscar_categoria().Tables[0];
                    ddl_categoria.DataTextField = "NOMBRE";
                    ddl_categoria.DataValueField = "CODIGO";
                    ddl_categoria.DataBind();
                    ddl_municipio.DataSource = eventado.buscar_municipio().Tables[0];
                    ddl_municipio.DataTextField = "NOMBRE";
                    ddl_municipio.DataValueField = "CODIGO";
                    ddl_municipio.DataBind();
                    refrescar();


                    dgb_todos.HeaderRow.Cells[3].Text = "Nombre Del Evento";
                    dgb_todos.HeaderRow.Cells[2].Text = "Descripción";
                    dgb_todos.HeaderRow.Cells[24].Text = "Nombre Del Usuario";
                    dgb_todos.HeaderRow.Cells[25].Text = "Apellido Del Usuario";
                    dgb_todos.HeaderRow.Cells[26].Text = "Teléfono";
                    dgb_todos.HeaderRow.Cells[28].Text = "Correo";
                    dgb_todos.HeaderRow.Cells[29].Text = "Alias del Usuario";


                }
            }
            catch
            {

            }
        }
        public void usuario(int fila)
        {
            try
            {
                DataRow row = obj.buscar().Tables[0].Rows[fila];
                txt_usuario.Text = Convert.ToString(row[0]);
                txt_usuario.DataBind();
            }
            catch
            {

            }

        }
        public EventoBO devolver()
        {
           
            

                EventoBO obj = new EventoBO();

                int id = 0; int.TryParse(txtid.Value, out id);

                obj.Codigo = id;
                obj.Descripcion = txt_descrip.Text;
                obj.Nombre = txt_nombre.Text;
                obj.costo = Convert.ToDouble(txt_precio.Text);
                obj.FechaApertura = Convert.ToDateTime(txt_aperura.Text);
                obj.FechaCierre = Convert.ToDateTime(txt_fecha_cierre.Text);
                obj.FotoPromocion = file_foto.ToString();
                obj.UbicacionGeografica = txt_ubicar.Text;
                obj.longitud = txt_lo.Text;
                obj.latitud = txtlat.Text;
                obj.visitas = 0;
                obj.FotoPromocion = strNuevoNombre;
                obj.aprovacion = valor;//valor desaprovado 
                                       //obj.CodigoDireccion = Convert.ToInt32(iddir.ToString());
                obj.CodigoCategoria = Convert.ToInt32(ddl_categoria.SelectedValue);
                obj.CodigoUsuario = Convert.ToInt32(txt_usuario.Text);
                //
                int iddir = 0; int.TryParse(txt_codir.Value, out iddir);
                obj.Codigo_dir = iddir;
                obj.Colonia = txt_colonia.Text;
                obj.CodigoPostal = txt_postal.Text;
                obj.Cruzamiento = txt_crizamiento.Text;
                obj.NumeroExterior = txt_numexter.Text;
                obj.NumeroInterior = txt_numint.Text;
                obj.CodigoMunicipio = Convert.ToInt32(ddl_municipio.SelectedValue);
                //

                return obj;
    



        }
        public void refrescar()
        {
            try
            {


                dgb_todos.DataSource = eventado.buscar_usuriounico(id);
                dgb_todos.DataBind();
            }
            catch { }

        }
        protected void txt_nombre_TextChanged(object sender, EventArgs e)
        {

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
        protected void accion(object sender, EventArgs e)
        {
            try
            {


                var btnSeleccionado = (Button)sender;
                // cargar la foto
                if (btnSeleccionado.ID == "btn_agregar")
                {
                    if (file_foto.HasFile)
                    {
                        strNuevoNombre = NombreImagen();
                        file_foto.SaveAs(Server.MapPath("~/img/") + strNuevoNombre + ".jpg");
                    }
                    //FileUploadFoto.Save("miimagen.jpg",ImageFormat.Jpeg);
                }
                if (btnSeleccionado.ID == "btn_modificar")
                {
                    if (file_foto.HasFile)
                    {
                        File.Delete(MapPath(Image1.ImageUrl));
                        strNuevoNombre = NombreImagen();
                        file_foto.SaveAs(Server.MapPath("~/img/") + strNuevoNombre + ".jpg");
                    }
                    //FileUploadFoto.Save("miimagen.jpg",ImageFormat.Jpeg);
                }
                if (btnSeleccionado.ID == "btn_eliminar")
                {
                    if (file_foto.HasFile)
                    {
                        File.Delete("~/img/" + Image1.ImageUrl);
                    }
                    //FileUploadFoto.Save("miimagen.jpg",ImageFormat.Jpeg);
                }

                Button btnsellcionado = (Button)sender;

                control.accion(devolver(), btnsellcionado.ID);
                // ser_direccion.accion(mandar(), btnsellcionado.ID);
                refrescar();
                Response.Write("<script>window.alert('Bien hecho');</script>");
            }
            catch
            {
                Response.Write("<script>window.alert('Aocurrido un error intentelo de nuevo');</script>");
            }

        }
        public void usuario1()
        {
            try
            {


                UsuarioBO obj = new UsuarioBO();
                obj.Usuario.ToString();
                obj.Contraseña.ToString();
                txt_usuario.Text = login.verificar(obj).ToString();
            }
            catch
            {

            }
        }

        protected void mandar(object sender, GridViewCommandEventArgs e)
        {
            try
            {


                if (e.CommandName == "btn_seleccionar")
                {
                    //foto promocion 7
                    //int fila = Convert.ToInt32(e.CommandArgument.ToString());

                    int fila = Convert.ToInt32(e.CommandArgument);
                    txtid.Value = dgb_todos.Rows[fila].Cells[1].Text;
                    txt_ubicar.Text = dgb_todos.Rows[fila].Cells[8].Text;
                    txt_lo.Text = dgb_todos.Rows[fila].Cells[10].Text;
                    txtlat.Text = dgb_todos.Rows[fila].Cells[9].Text;
                    DateTime fechaapertura = Convert.ToDateTime(dgb_todos.Rows[fila].Cells[5].Text);
                    txt_aperura.Text = fechaapertura.ToString("yyyy-MM-dd");
                    txt_codir.Value = dgb_todos.Rows[fila].Cells[12].Text;
                    txt_colonia.Text = dgb_todos.Rows[fila].Cells[17].Text;
                    txt_crizamiento.Text = dgb_todos.Rows[fila].Cells[19].Text;
                    txt_descrip.Text = Page.Server.HtmlDecode(dgb_todos.Rows[fila].Cells[2].Text);
                    DateTime ida = Convert.ToDateTime(dgb_todos.Rows[fila].Cells[6].Text);
                    txt_fecha_cierre.Text = ida.ToString("yyyy-MM-dd");
                    txt_nombre.Text = Page.Server.HtmlDecode(dgb_todos.Rows[fila].Cells[3].Text);
                    txt_numexter.Text = dgb_todos.Rows[fila].Cells[21].Text;
                    txt_numint.Text = dgb_todos.Rows[fila].Cells[20].Text;
                    txt_postal.Text = dgb_todos.Rows[fila].Cells[18].Text;
                    txt_precio.Text = dgb_todos.Rows[fila].Cells[4].Text;
                    txt_codir.Value = dgb_todos.Rows[fila].Cells[16].Text;
                    txt_visitas.Text = dgb_todos.Rows[fila].Cells[15].Text;
                    Image1.ImageUrl = "img/" + dgb_todos.Rows[fila].Cells[7].Text.ToString() + ".jpg";
                    //  rbt_aprovado.Checked = (Convert.ToString(dgb_todos.Rows[fila].Cells[11].Text) != "0") ? true : false;
                    // rbt_noapro.Checked = (Convert.ToString(dgb_todos.Rows[fila].Cells[11].Text) == "0") ? true : false;
                    txt_usuario.Text = dgb_todos.Rows[fila].Cells[22].Text;
                    ddl_categoria.SelectedValue = dgb_todos.Rows[fila].Cells[13].Text;
                    ddl_municipio.SelectedValue = dgb_todos.Rows[fila].Cells[22].Text;
                }
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
                e.Row.Cells[6].Visible = false;
                e.Row.Cells[7].Visible = false;
                e.Row.Cells[8].Visible = false;
                e.Row.Cells[9].Visible = false;
                e.Row.Cells[10].Visible = false;
                e.Row.Cells[11].Visible = false;
                e.Row.Cells[12].Visible = false;
                e.Row.Cells[11].Visible = false;
                e.Row.Cells[13].Visible = false;
                e.Row.Cells[14].Visible = false;
                e.Row.Cells[15].Visible = false;
                e.Row.Cells[16].Visible = false;
                e.Row.Cells[17].Visible = false;
                e.Row.Cells[18].Visible = false;
                e.Row.Cells[19].Visible = false;
                e.Row.Cells[20].Visible = false;
                e.Row.Cells[21].Visible = false;
                e.Row.Cells[22].Visible = false;
                e.Row.Cells[23].Visible = false;

                e.Row.Cells[31].Visible = false;
                e.Row.Cells[30].Visible = false;
                e.Row.Cells[32].Visible = false;
                e.Row.Cells[27].Visible = false;
            }
            catch { }
        }
    }
}