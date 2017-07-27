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

namespace GUI
{
    public partial class frm_mensaje : System.Web.UI.Page
    {
        mensajeDAO mensaje = new mensajeDAO();
      


        protected void Page_Load(object sender, EventArgs e)
        {
            refresh();
            txt_evento.Value = Session["evento"].ToString();
            txt_usuairo.Value = Session["usuario"].ToString();
          
            txt_idusuariooconectado.Value = Session["id"].ToString();
            




        }
        public void refresh()

        {
            dgb_mismensajes.DataSource = mensaje.buscar();
            dgb_mismensajes.DataBind();
        }

        public MensajeBO recuperar()
        {
            MensajeBO dato = new MensajeBO();
            int id = 0;int.TryParse(txt_id.Value, out id);
            dato.Codigo = id;
            dato.Cuerpo=txt_mensaje.Text;
            dato.CodigoEvento = Convert.ToInt32(txt_evento.Value);
            dato.CodigoUsuario = Convert.ToInt32(txt_idusuariooconectado.Value);
            dato.Destinatario ="ORGANIZADOR";
            dato.Remitente = txt_usuairo.Value;
            dato.Status =Convert.ToBoolean( 0);
            return dato;




        }

        protected void enviar(object sender, EventArgs e)
        {
            mensaje.agregar(recuperar());
            refresh();
            txt_mensaje.Text = "";
            Response.Write("<script>window.alert('mensaje enviado');</script>");
        }

        protected void dgb_mismensajes_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            
        }

        protected void dgb_mismensajes_RowCreated(object sender, GridViewRowEventArgs e)
        {
            e.Row.Cells[1].Visible = false;
            e.Row.Cells[2].Visible = false;
            e.Row.Cells[7].Visible = false;
            e.Row.Cells[6].Visible = false;
            e.Row.Cells[3].Visible = false;

        }

        protected void dgb_mismensajes_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "btn_leer")
            {
                //foto promocion 7
                //int fila = Convert.ToInt32(e.CommandArgument.ToString());

                int fila = Convert.ToInt32(e.CommandArgument);
                txt_resivido.Text = dgb_mismensajes.Rows[fila].Cells[5].Text;
                int id = int.Parse(dgb_mismensajes.Rows[fila].Cells[1].Text);

          
                mensaje.modificarmensajedao(id);
                
                refresh();
            }
        }
    }
    
}