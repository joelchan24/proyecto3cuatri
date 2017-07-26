using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BO;
using DAO;

namespace GUI
{
    public partial class frm_mensajesdelorgaizador : System.Web.UI.Page
    {
        mensajeDAO mensaje = new mensajeDAO();
        protected void Page_Load(object sender, EventArgs e)
        {
            refresh();
        }
        public void refresh()

        {
            Gridview1.DataSource = mensaje.buscar();
            Gridview1.DataBind();
        }
        public MensajeBO recuperar()
        {
            MensajeBO dato = new MensajeBO();
            int id = 0; int.TryParse(txt_id.Value, out id);
            dato.Codigo = id;
            dato.Cuerpo = txt_mensaje.Text;
            dato.CodigoEvento = Convert.ToInt32(txt_evento.Value);
            dato.CodigoUsuario = Convert.ToInt32(txt_idusuariooconectado.Value);
            dato.Destinatario = "USUARIO";
            dato.Remitente = txt_usuairo.Value;
            dato.Status = Convert.ToBoolean(0);
            return dato;




        }

        protected void Gridview1_RowCreated(object sender, GridViewRowEventArgs e)
        {

            e.Row.Cells[1].Visible = false;
            e.Row.Cells[2].Visible = false;
            e.Row.Cells[7].Visible = false;
            e.Row.Cells[6].Visible = false;
            e.Row.Cells[3].Visible = false;
        }

        protected void Gridview1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "btn_mensa")
            {
                //foto promocion 7
                //int fila = Convert.ToInt32(e.CommandArgument.ToString());

                int fila = Convert.ToInt32(e.CommandArgument);
                txt_resivido.Text = Gridview1.Rows[fila].Cells[5].Text;
                int id = int.Parse(Gridview1.Rows[fila].Cells[1].Text);


                mensaje.modificarmensajedao(id);

                refresh();
            }
        }

        protected void btn_enviar_Click(object sender, EventArgs e)
        {
            mensaje.agregar(recuperar());
            refresh();
            txt_mensaje.Text = "";
            Response.Write("<script>window.alert('mensaje enviado');</script>");
        }
    }
}