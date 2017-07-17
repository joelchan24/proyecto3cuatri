using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using BO;
using DAO;
using Services;

namespace AdministradorGUI
{
    public partial class admi_de_eventosGUI : System.Web.UI.Page
    {
        ctrol_dirrecionSERVICIOS ser_direccion = new ctrol_dirrecionSERVICIOS();
        ctrol_eventosSERVICIO control = new ctrol_eventosSERVICIO();
        eventoDAO eventado = new eventoDAO();
        protected void Page_Load(object sender, EventArgs e)
        {

        if(!IsPostBack)
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

        protected void btn_eliminar_Click(object sender, EventArgs e)
        {

        }

        protected void txt_codir_ValueChanged(object sender, EventArgs e)
        {

        }
      
        public EventoBO devolver()
        {
            EventoBO obj = new EventoBO();

            int id = 0; int.TryParse(txtid.Value, out id);
            int iddir = 0;int.TryParse(txt_codir.Value, out iddir);
            obj.Codigo = id;
            obj.Descripcion =txt_descrip.Text;
            obj.Nombre = txt_nombre.Text;
            obj.costo = Convert.ToInt32(txt_precio.Text);
            //obj.FechaApertura =txt_aperura.val;
            obj.FechaCierre = Convert.ToDateTime(txt_fecha_cierre.Text);
            obj.FotoPromocion = file_foto.ToString();
            obj.UbicacionGeografica = txt_ubicar.Text;
            obj.longitud = txt_lo.Text;
            obj.latitud = txtlat.Text;
            obj.aprovacion=(rbt_aprovado.Checked)? "aprovado" : "no aprovado";
            obj.CodigoDireccion = Convert.ToInt32(iddir.ToString());
            obj.CodigoCategoria = Convert.ToInt32(ddl_categoria.SelectedValue);
            obj.CodigoUsuario =Convert.ToInt32( txt_usuario.Text);
            return obj;



        }
        public Direccion mandar()
        {
            Direccion dir = new Direccion();

           
            int iddir = 0; int.TryParse(txt_codir.Value, out iddir);
            dir.Codigo = iddir;
            dir.Colonia = txt_colonia.Text;
            dir.CodigoPostal = txt_postal.Text;
            dir.Cruzamiento = txt_crizamiento.Text;
            dir.NumeroExterior = txt_numexter.Text;
            dir.NumeroInterior = txt_numint.Text;
            dir.CodigoMunicipio = Convert.ToInt32(ddl_municipio.SelectedValue);
           
         
            return dir;



        }
        public void refrescar()
        {

            dgb_eventos.DataSource= eventado.buscar();
            dgb_eventos.DataBind();
           
        }

        protected void dgb_eventos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void mandaraltexvo(object sender, GridViewCommandEventArgs e)
        {
           // if (e.CommandName == "btn_selecionar")
                //  {
                //foto promocion 7
                int fila = Convert.ToInt32(e.CommandArgument.ToString());
            txtid.Value = dgb_eventos.Rows[fila].Cells[1].Text;
            txt_ubicar.Text = dgb_eventos.Rows[fila].Cells[8].Text;
            txt_lo.Text = dgb_eventos.Rows[fila].Cells[10].Text;
            txtlat.Text = dgb_eventos.Rows[fila].Cells[9].Text;
          txt_aperura.Text= dgb_eventos.Rows[fila].Cells[5].Text;
            txt_codir.Value= dgb_eventos.Rows[fila].Cells[13].Text;
            txt_colonia.Text= dgb_eventos.Rows[fila].Cells[14].Text;
            txt_crizamiento.Text= dgb_eventos.Rows[fila].Cells[16].Text;
            txt_descrip.Text= dgb_eventos.Rows[fila].Cells[2].Text;
            txt_fecha_cierre.Text= dgb_eventos.Rows[fila].Cells[6].Text;
            txt_nombre.Text= dgb_eventos.Rows[fila].Cells[3].Text;
            txt_numexter.Text= dgb_eventos.Rows[fila].Cells[18].Text;
            txt_numint.Text= dgb_eventos.Rows[fila].Cells[17].Text;
            txt_postal.Text= dgb_eventos.Rows[fila].Cells[15].Text;
            txt_precio.Text= dgb_eventos.Rows[fila].Cells[4].Text;
            rbt_aprovado.Checked = (Convert.ToString(dgb_eventos.Rows[fila].Cells[11].Text) == "aprovado") ? true : false;
            rbt_noapro.Checked = (Convert.ToString(dgb_eventos.Rows[fila].Cells[11].Text) == "no aprovado") ? true : false;
            txt_usuario.Text= dgb_eventos.Rows[fila].Cells[3].Text;
            ddl_categoria.SelectedValue= dgb_eventos.Rows[fila].Cells[12].Text;
            ddl_municipio.SelectedValue= dgb_eventos.Rows[fila].Cells[19].Text;

            // }
        }

        protected void dgb_eventos_RowCreated(object sender, GridViewRowEventArgs e)
        {
            e.Row.Cells[1].Visible = false;
        }

        protected void accion(object sender, EventArgs e)
        {
            Button btnsellcionado = (Button)sender;

           control.accion(devolver(), btnsellcionado.ID);
           // ser_direccion.accion(mandar(), btnsellcionado.ID);
            refrescar();


        }

        protected void btn_eliminar_Click1(object sender, EventArgs e)
        {

        }
    }
}