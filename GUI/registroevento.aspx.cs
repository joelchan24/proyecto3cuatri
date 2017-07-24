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
            
               
                txt_usuario.Text =  Session["id"].ToString();//jale el id usuario
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

            dgb_todos.DataSource = eventado.buscar_usuriounico(id);
            dgb_todos.DataBind();

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

        }
        public void usuario1()
        {
            UsuarioBO obj = new UsuarioBO();
            obj.Usuario.ToString();
            obj.Contraseña.ToString();
            txt_usuario.Text = login.verificar(obj).ToString();
        }

        protected void mandar(object sender, GridViewCommandEventArgs e)
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
                txt_descrip.Text = dgb_todos.Rows[fila].Cells[2].Text;
                DateTime ida = Convert.ToDateTime(dgb_todos.Rows[fila].Cells[6].Text);
                txt_fecha_cierre.Text = ida.ToString("yyyy-MM-dd");
                txt_nombre.Text = dgb_todos.Rows[fila].Cells[3].Text;
                txt_numexter.Text = dgb_todos.Rows[fila].Cells[21].Text;
                txt_numint.Text = dgb_todos.Rows[fila].Cells[20].Text;
                txt_postal.Text = dgb_todos.Rows[fila].Cells[18].Text;
                txt_precio.Text = dgb_todos.Rows[fila].Cells[4].Text;
                txt_codir.Value = dgb_todos.Rows[fila].Cells[16].Text;
                txt_visitas.Text = dgb_todos.Rows[fila].Cells[15].Text;
                Image1.ImageUrl = "img/" + dgb_todos.Rows[fila].Cells[7].Text.ToString() + ".jpg";
                rbt_aprovado.Checked = (Convert.ToString(dgb_todos.Rows[fila].Cells[11].Text) != "0") ? true : false;
                rbt_noapro.Checked = (Convert.ToString(dgb_todos.Rows[fila].Cells[11].Text) == "0") ? true : false;
                txt_usuario.Text = dgb_todos.Rows[fila].Cells[22].Text;
                ddl_categoria.SelectedValue = dgb_todos.Rows[fila].Cells[13].Text;
                ddl_municipio.SelectedValue = dgb_todos.Rows[fila].Cells[22].Text;
            }
        }
    }
}