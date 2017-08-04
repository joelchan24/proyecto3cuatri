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
        public int id;


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                id = Convert.ToInt32(Session["id"]);
                DropDownList1.DataSource = mensaje.usuario(id).Tables[0];
                DropDownList1.DataTextField = "USUARIO";
                DropDownList1.DataValueField = "CODIGO";
                DropDownList1.DataBind();
                refresh();

            }
           
           
         //   txt_usuairo.Value = Session["usuario"].ToString();
          
         //   txt_idusuariooconectado.Value = Session["id"].ToString();
            
            



        }
        public void refresh()

        {
            dgb_mismensajes.DataSource = mensaje.buscarmensaje(id);
            dgb_mismensajes.DataBind();
        }

        public MensajeBO recuperar()
        {
            MensajeBO dato = new MensajeBO();
            int id = 0; int.TryParse(txt_id.Value, out id);
            dato.Codigo = id;
            dato.Cuerpo = txt_mensaje.Text;
            dato.CodigoUsuario = Convert.ToInt32(Session["id"]);
            dato.Destinatario = DropDownList1.SelectedValue;
            dato.Remitente = Session["usuario"].ToString();
            dato.Status = Convert.ToBoolean(1);
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
        /*    e.Row.Cells[1].Visible = false;
            e.Row.Cells[2].Visible = false;
            e.Row.Cells[7].Visible = false;
            e.Row.Cells[6].Visible = false;
            e.Row.Cells[3].Visible = false;*/

        }

        protected void dgb_mismensajes_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "btn_leer")
            {
                //foto promocion 7
                //int fila = Convert.ToInt32(e.CommandArgument.ToString());

                int fila = Convert.ToInt32(e.CommandArgument);
                txt_resivido.Text = dgb_mismensajes.Rows[fila].Cells[5].Text;
                DropDownList1.SelectedValue= dgb_mismensajes.Rows[fila].Cells[6].Text;
                int id = int.Parse(dgb_mismensajes.Rows[fila].Cells[1].Text);

          
                mensaje.modificarmensajedao1(id);
                
                refresh();
            }
        }
    }
    
}