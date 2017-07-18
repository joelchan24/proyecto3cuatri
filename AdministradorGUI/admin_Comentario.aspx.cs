using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BO;
using DAO;
using Services;

namespace AdministradorGUI
{
    public partial class admin_Comentario : System.Web.UI.Page
    {
        CTRL_comentario oCTRLComentario = new CTRL_comentario();

        

        protected void Page_Load(object sender, EventArgs e)
        {
            actualizar();
        }
        public void actualizar()
        {
            dvg_mensaje.DataSource = oCTRLComentario.listar().Tables[0];
            dvg_mensaje.DataBind();
        }
        public ComentarioBO RecolectarDAtos()
        {
            ComentarioBO oComentarioBO = new ComentarioBO();
            int ID = 0; int.TryParse(txt_ID.Text, out ID);
            oComentarioBO.Codigo = ID;
            oComentarioBO.Comentario = txt_Comentario.Text;
            oComentarioBO.CodigoEvento = int.Parse(txt_Evento.Text);
            oComentarioBO.CodigoUsuario = int.Parse(txt_Usuario.Text);
            return oComentarioBO;
        }

        protected void Accion(object sender, EventArgs e)
        {
            Button btnSelecionado = (Button)sender;
            oCTRLComentario.Accion(btnSelecionado.ID, RecolectarDAtos());
            actualizar();
            Limpiar();
        }

        protected void Seleccionar(object sender, GridViewCommandEventArgs e)
        {
            int indice = Convert.ToInt32(e.CommandArgument);
            txt_ID.Text = dvg_mensaje.Rows[indice].Cells[1].Text;
            txt_Evento.Text = dvg_mensaje.Rows[indice].Cells[3].Text;
            txt_Usuario.Text = dvg_mensaje.Rows[indice].Cells[4].Text;
            txt_Comentario.Text = dvg_mensaje.Rows[indice].Cells[2].Text;
        }

        public void Limpiar()
        {
            txt_Comentario.Text = "";
            txt_Evento.Text = "";
            txt_ID.Text = "";
            txt_Usuario.Text = "";
        }
    }
}